using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PC_Building.Bots
{
    public partial class PCBuildingBot : Form
    {
        UserDialogProfile profile = new UserDialogProfile();
        string strCon = ConfigurationManager.ConnectionStrings["CaseBuilder"].ConnectionString;
        SqlConnection sqlCon = null;
        string currentUser = "";
        public PCBuildingBot(string currentUser)
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            this.AcceptButton = button1;
            RunBot();
            this.currentUser = currentUser;
        }
        private void customRichTextBox(string text, Font font, Color color, HorizontalAlignment alignment = HorizontalAlignment.Left)
        {
            richTextBox1.SelectionAlignment = alignment;
            richTextBox1.SelectionFont = font;
            richTextBox1.SelectionColor = color;
            richTextBox1.SelectedText = text;

        }
        private void BotChat(string chat)
        {
            customRichTextBox(DateTime.Now.ToString() + "\n", new Font("Bahnschrift", 8f, FontStyle.Regular), Color.Gray);
            customRichTextBox("Assistant:\n", new Font("Bahnschrift", 13f, FontStyle.Bold), Color.Green);
            customRichTextBox(chat + "\n\n", new Font("Bahnschrift", 11f, FontStyle.Regular), Color.Black);
        }
        private void RunBot()
        {
            ProcessorStep();
        }
        private async void StorageStep()
        {
            BotChat("What is your Storage?");
            textBox1.Focus();
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from Storage where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.Storage = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        PowerSupplyStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    PowerSupplyStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    StorageStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    PowerSupplyStep();
                }

            }
        }

        private async void PowerSupplyStep()
        {
            BotChat("What is your Power Supply Unit?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from [Power Supply] where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.PowerSupply = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        BuildStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    BuildStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    PowerSupplyStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    BuildStep();
                }

            }
        }

        private async void CaseCoolerStep()
        {
            BotChat("What is your Case Cooler?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from [Case Cooler] where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.CaseCooler = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        CPUCoolerStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CPUCoolerStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CaseCoolerStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CPUCoolerStep();
                }

            }
        }

        private async void CPUCoolerStep()
        {
            BotChat("What is your CPU Cooler?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from [CPU Cooler] where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.CPUCooler = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        StorageStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    StorageStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CPUCoolerStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    StorageStep();
                }

            }
        }

        private async void CaseStep()
        {
            BotChat("What is your Case?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from [Case] where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.Case = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        CaseCoolerStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CaseCoolerStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CaseStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CaseCoolerStep();
                }

            }
        }

        private async void RamStep()
        {
            BotChat("What is your Ram?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from [Ram] where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.Ram = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        GraphicCardStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    GraphicCardStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    RamStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    GraphicCardStep();
                }

            }
        }

        private async void GraphicCardStep()
        {
            BotChat("What is your Graphic Card?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from [Graphic Card] where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.GraphicCard = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        CaseStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CaseStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    GraphicCardStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    CaseStep();
                }

            }
        }

        private async void MotherboardStep()
        {
            BotChat("What is your Motherboard?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from Motherboard where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.Motherboard = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        RamStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    RamStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    MotherboardStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    RamStep();
                }

            }
        }

        private async void ProcessorStep()
        {
            BotChat("What is your Processor?");
            await WaitOneAsync(resetEvent);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from Processor where Model like '%" + textBox1.Text + "%'";
            textBox1.Text = "";
            textBox1.Focus();
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                string chat = "The models match your given name is: \n";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    chat += (i + 1) + ". " + Table.Rows[i][0].ToString() + "\n";
                }
                chat += "Which one is your exact model? Please indicate the number.";
                BotChat(chat);
                int selection = -1;
                while (selection <= 0)
                {
                    await WaitOneAsync(resetEvent);
                    int.TryParse(textBox1.Text, out selection);
                    if (selection <= 0)
                    {
                        BotChat("Invalid answer. Please try again");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        BotChat(Table.Rows[selection - 1][0].ToString() + " is selected.");
                        profile.Processor = Table.Rows[selection - 1][0].ToString();
                        textBox1.Text = "";
                        textBox1.Focus();
                        sqlCon.Close();
                        MotherboardStep();
                    }
                }

            }
            else
            {
                BotChat("There is no product match your given name. Do you want to skip?(Yes/No)");
                await WaitOneAsync(resetEvent);
                string answer = textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("Processor is skipped.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    MotherboardStep();
                }
                else
                    if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    ProcessorStep();
                }
                else
                {
                    BotChat("Answer is unidentified. Skip this section");
                    textBox1.Text = "";
                    textBox1.Focus();
                    sqlCon.Close();
                    MotherboardStep();
                }

            }

        }
        private ManualResetEvent resetEvent = new ManualResetEvent(false);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private async Task WaitOneAsync(ManualResetEvent resetEvent)
        {
            await Task.Run(() => resetEvent.WaitOne());
            resetEvent.Reset();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resetEvent.Set();
            customRichTextBox(DateTime.Now.ToString() + "\n", new Font("Bahnschrift", 8f, FontStyle.Regular), Color.Gray, HorizontalAlignment.Right);
            customRichTextBox("You:\n", new Font("Bahnschrift", 13f, FontStyle.Bold), Color.Blue, HorizontalAlignment.Right);
            customRichTextBox(textBox1.Text + "\n\n", new Font("Bahnschrift", 11f, FontStyle.Regular), Color.Black, HorizontalAlignment.Right);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }
        private void SqlCommandExecuter(string cmd)
        {
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandText = cmd;
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }
        private DataTable SqlCommandTable(string cmd)
        {
            sqlCon.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter();
            SqlCommand sqlCmd;
            DataTable table = new DataTable();
            sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandText = cmd;
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(table);
            sqlCon.Close();
            return table;
        }
        private async void BuildStep()
        {
            string chat = "Your current build is:\n"
                + "Processor: " + profile.Processor + "\n"
                + "Motherboard: " + profile.Motherboard + "\n"
                + "RAM: " + profile.Ram + "\n"
                + "Graphic Card: " + profile.GraphicCard + "\n"
                + "Case: " + profile.Case + "\n"
                + "Case Cooler: " + profile.CaseCooler + "\n"
                + "CPU Cooler: " + profile.CPUCooler + "\n"
                + "Storage: " + profile.Storage + "\n"
                + "Power Supply: " + profile.PowerSupply + "\n"
                + "Do you want to build this setup?(Yes/No)";
            BotChat(chat);
            await WaitOneAsync(resetEvent);
            string answer = textBox1.Text.ToLower();
            if (answer == "yes")
            {              
                SqlCommandExecuter("update [Build List] set Processor='" + profile.Processor + "', Motherboard='" + profile.Motherboard
                    + "', RAM='" + profile.Ram + "', [Case]='" + profile.Case+ "', [Case Cooler]='"+profile.CaseCooler+"', [CPU Cooler]='"+profile.CPUCooler+"', Storage='" + profile.Storage + "', [Power Supply]='" + profile.PowerSupply+ "' where [Name]='temporary-cache'");
                PC_Building A = new PC_Building("Yes", currentUser);
                A.Show();
                this.Close();
            }
            else
                if (answer == "no")
            {
                textBox1.Text = "";
                textBox1.Focus();
                BotChat("Do you want to save this build?(Yes/No)");
                await WaitOneAsync(resetEvent);
                answer= textBox1.Text.ToLower();
                if (answer == "yes")
                {
                    BotChat("What will be the name of your build?");
                    textBox1.Text = "";
                    textBox1.Focus();
                    await WaitOneAsync(resetEvent);
                    string saveName = textBox1.Text;
                    textBox1.Text = "";
                    textBox1.Focus();
                    string username;
                    if (!String.IsNullOrEmpty(currentUser))
                    {
                        username = currentUser;
                    }
                    else
                    {
                        username = "Guest";
                    }
                    DataTable table = SqlCommandTable("Select Name from [Build List] where Name = '" + saveName + "' and Owner = '" + username + "'");
                    while(table.Rows.Count > 0)
                    {
                        BotChat("Save name is already existed. Please choose different name.\nWhat will be the name of your build?");
                        await WaitOneAsync(resetEvent);
                        saveName = textBox1.Text;
                        textBox1.Text = "";
                        textBox1.Focus();
                        table.Clear();
                        table= SqlCommandTable("Select Name from [Build List] where Name = '" + saveName + "' and Owner = '" + username + "'");
                    }
                    SqlCommandExecuter("insert into [Build List] values ('" + saveName + "','" + profile.Processor + "','" + profile.Case+ "','" + profile.Motherboard
                    + "','" + profile.CaseCooler+ "','" + profile.CPUCooler + "','" + profile.GraphicCard + "','" + profile.Ram + "','" + profile.Storage
                    + "','" + profile.PowerSupply + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + username + "')");
                    BotChat("Build Saved. Auto close form in 10 seconds.");
                    await Task.Delay(10000);
                    this.Close();
                }
                else
                if (answer == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    BotChat("Build is abadoned. Auto close form in 10 seconds.");
                    await Task.Delay(10000);
                    this.Close();
                }
                else
                {
                    BotChat("Answer is unidentified. Auto cancel request and close this form in 10 seconds.");
                    textBox1.Text = "";
                    textBox1.Focus();
                    await Task.Delay(10000);
                    this.Close();
                }
            }
            else
            {
                BotChat("Answer is unidentified. Auto cancel request and close this form in 10 seconds.");
                textBox1.Text = "";
                textBox1.Focus();
                await Task.Delay(10000);
                this.Close();
            }
        }
    }

    class UserDialogProfile
    {
        public string Processor = "";
        public string Motherboard = "";
        public string GraphicCard = "";
        public string Ram = "";
        public string Case = "";
        public string CaseCooler = "";
        public string CPUCooler = "";
        public string Storage = "";
        public string PowerSupply = "";
    }
}
