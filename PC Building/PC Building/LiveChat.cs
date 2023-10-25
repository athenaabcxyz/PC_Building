using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using PC_Building.Bots;
using System.Xml.Linq;

namespace PC_Building
{
    public partial class LiveChat : Form
    {
        string currentUser = "";
        string strCon = ConfigurationManager.ConnectionStrings["CaseBuilder"].ConnectionString;
        SqlConnection sqlCon = null;
        public LiveChat(string user)
        {
            InitializeComponent();

            this.AcceptButton = button1;
            sqlCon = new SqlConnection(strCon);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            currentUser = user;

            LoadMessage();
        }
        public event EventHandler ShutDownLiveChat;

        public void UpdateUserInfo(string newuser)
        {
            currentUser = newuser;
            if (currentUser != "")
            {
                textBox1.Enabled = false;
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable table = new DataTable();
                sqlCmd.CommandText = "Select CustomName from UserInfo where UserName = '" + currentUser + "'";
                Adapter.SelectCommand = sqlCmd;
                Adapter.Fill(table);
                textBox1.Text = table.Rows[0][0].ToString();
                sqlCon.Close();
                LoadMessage();
            }
            else
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
            }
        }
        void LoadMessage()
        {
            richTextBox_chatlist.Clear();
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable table = new DataTable();
            sqlCmd.CommandText = "Select * from LiveChat order by ID ASC";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(table);
            int k = 0;
            if (table.Rows.Count > 40)
                k = table.Rows.Count - 40;
            for (int i = k; i < table.Rows.Count; i++)
            {
                customRichTextBox(table.Rows[i][4].ToString() + "\n", new Font("Bahnschrift", 8f, FontStyle.Regular), Color.Gray, (currentUser == table.Rows[i][1].ToString() && table.Rows[i][1].ToString() != "") ? HorizontalAlignment.Right : HorizontalAlignment.Left);
                customRichTextBox(table.Rows[i][2] + ":\n", new Font("Bahnschrift", 13f, FontStyle.Bold), (currentUser == table.Rows[i][1].ToString() && table.Rows[i][1].ToString() != "") ? Color.Blue : Color.Black, (currentUser == table.Rows[i][1].ToString() && table.Rows[i][1].ToString() != "") ? HorizontalAlignment.Right : HorizontalAlignment.Left);
                customRichTextBox(table.Rows[i][3] + "\n\n", new Font("Bahnschrift", 11f, FontStyle.Regular), Color.Black, (currentUser == table.Rows[i][1].ToString() && table.Rows[i][1].ToString() != "") ? HorizontalAlignment.Right : HorizontalAlignment.Left);
            }
            sqlCon.Close();
            button1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (LivechatSupportBotCommand(richTextBox1.Text))
            {
                return;
            }
            else
            {
                int Number = 0;
                string name = "";
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable table = new DataTable();
                sqlCmd.CommandText = "Select * from LiveChat order by ID ASC";
                Adapter.SelectCommand = sqlCmd;
                Adapter.Fill(table);
                Number = table.Rows.Count;
                Number++;
                if (string.IsNullOrEmpty(textBox1.Text))
                    name = "Anonymous";
                else
                    name = textBox1.Text;
                string A = richTextBox1.Text;
                for (int k = 0; k < A.Length; k++)
                {
                    if (A[k] == '\'')
                    {
                        A = A.Substring(0, k) + "'" + A.Substring(k);
                        k++;
                    }
                }
                string B = DateTime.Now.ToString();
                for (int k = 0; k < B.Length; k++)
                {
                    if (B[k] == '\'')
                    {
                        B = B.Substring(0, k) + "'" + B.Substring(k);
                        k++;
                    }
                }
                sqlCmd.CommandText = "Insert into LiveChat values(" + Number + ",'" + currentUser + "', N'" + name + "',N'" + A + "',N'" + B + "')";
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                richTextBox1.Clear();
                LoadMessage();
            }
        }

        private void BotChat(string chat)
        {
            customRichTextBox(DateTime.Now.ToString() + "\n", new Font("Bahnschrift", 8f, FontStyle.Regular), Color.Gray);
            customRichTextBox("Assistant:\n", new Font("Bahnschrift", 13f, FontStyle.Bold), Color.Green);
            customRichTextBox(chat + "\n\n", new Font("Bahnschrift", 11f, FontStyle.Regular), Color.Black);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
        private void customRichTextBox(string text, Font font, Color color, HorizontalAlignment alignment = HorizontalAlignment.Left)
        {
            richTextBox_chatlist.SelectionAlignment = alignment;
            richTextBox_chatlist.SelectionFont = font;
            richTextBox_chatlist.SelectionColor = color;
            richTextBox_chatlist.SelectedText = text;
        }

        private void LiveChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to close the Live Chat section?", "Notice", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void LiveChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShutDownLiveChat(this, new EventArgs());
        }
        private string ListCommand(string name)
        {
            name = name.Remove(name.Length - 1);
            int count = 0;
            string output = "";
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from Processor where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "PROCESSOR:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from Motherboard where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "MOTHERBOARD:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from RAM where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "RAM:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Graphic Card] where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "GRAPHIC CARD:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Case] where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "CASE:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [CPU Cooler] where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "CPU COOLER:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Case Cooler] where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "CASE COOLER:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Power Supply] where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "POWER SUPPLY:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Storage] where Model like '%" + name + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                output += "Storage:\n\n";
                count += Table.Rows.Count;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    output += Table.Rows[i][0].ToString() + "\n------------------------\n";
                }
                output += "\n//////////////////////\n\n";
            }
            Table.Clear();
            sqlCon.Close();
            if (count > 0)
            {
                return output;
            }
            else
            {
                return "";
            }
        }
        private bool LivechatSupportBotCommand(string cmd)
        {
            cmd += " ";
            richTextBox1.Text = "";
            int firstSpace = FindFirstSpaceInString(cmd);
            if (firstSpace < 1)
                return false;
            else
            {
                string firstWorld = cmd.Substring(0, firstSpace);
                string nextWorld = cmd.Substring(firstSpace + 1);
                switch (firstWorld)
                {
                    case "!help":
                        if (String.IsNullOrEmpty(nextWorld))
                        {
                            string chat;
                            chat = "List of bot commands:" + "" +
                                "\n\n!check [Model name]: Get the detail info of product. [Model name] must be exact." +                               
                                "\n\n!list [name]: search in database for product has [name] in [Model name]."+
                                "\n\n!build: start a bot assistant to help you build a setup through chat."
                                ;
                            BotChat(chat);
                            return true;
                        }
                        break;
                    case "!check":
                        if(!String.IsNullOrEmpty(nextWorld))
                        {
                            BotCheckInfoCommand(nextWorld);
                            return true;
                        }
                        break;
                    case "!list":
                        if (nextWorld != "")
                        {
                            string chat;
                            chat = ListCommand(nextWorld);
                            if (String.IsNullOrEmpty(chat))
                            {
                                BotChat("There is no product match this name.");
                            }
                            else
                            {
                                BotChat("Below is the list of product(s) match the search:\n");
                                BotChat(chat);
                            }
                            return true;
                        }
                        else
                        {
                            break;
                        }
                    case "!build":
                        if (String.IsNullOrEmpty(nextWorld))
                        {
                            PCBuildingBot bot = new PCBuildingBot(currentUser);
                            bot.Show();
                            return true;
                        }
                        break;
                }
                return false;
            }
        }
        private int FindFirstSpaceInString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    return i;
            }
            return -1;
        }

        private void richTextBox_chatlist_TextChanged(object sender, EventArgs e)
        {
            richTextBox_chatlist.ScrollToCaret();
        }
        private void BotCheckInfoCommand(string model)
        {
            model = model.Remove(model.Length - 1);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model,'Processor' as Source from Processor where Model = '" + model + "'"
                + "union all select Model,'Motherboard' as Source from Motherboard where Model ='" + model+"'"
                + "union all select Model,'RAM' as Source from [RAM] where Model ='" + model + "'" 
                + "union all select Model,'Graphic Card' as Source from [Graphic Card] where Model ='" + model + "'" 
                + "union all select Model,'Case' as Source from [Case] where Model ='" + model + "'" 
                + "union all select Model,'Case Cooler' as Source from [Case Cooler] where Model ='" + model + "'" 
                + "union all select Model,'CPU Cooler' as Source from [CPU Cooler] where Model ='" + model + "'" 
                + "union all select Model,'Storage' as Source from [Storage] where Model ='" + model + "'" 
                + "union all select Model,'Power Supply' as Source from [Power Supply] where Model ='" + model + "'" 
                ;
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                for(int i = 0; i < Table.Rows.Count; i++)
                {
                    DataTable Table2 = new DataTable();
                    sqlCmd.CommandText="select * from [" + Table.Rows[i][1] +"] where Model ='"+ Table.Rows[i][0] + "'";
                    Adapter.SelectCommand = sqlCmd;
                    Adapter.Fill(Table2);
                    string chat = "";
                    for (int k = 0; k < Table2.Columns.Count; k++)
                    {
                        chat += Table2.Columns[k].ColumnName + ": " + Table2.Rows[0][k].ToString() + "\n";

                    }
                    BotChat(chat);
                }
            }
        }
    }

}
