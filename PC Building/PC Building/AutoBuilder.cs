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

namespace PC_Building
{
    public partial class AutoBuilder : Form
    {
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        Building_Simulator Build = new Building_Simulator();
        bool isTheBuildCompleted = false;
        public AutoBuilder()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            form_reset();
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
        private void form_reset()
        {
            isTheBuildCompleted = false;
            panel_motherboard.Enabled = false;
            panel_processor.Enabled = false;
            panel_case.Enabled = false;
            panel_psu.Enabled = false;
            panel_ram.Enabled = false;
            panel_storage.Enabled = false;
            tabControl1.SelectedIndex = 0;
            button_previous.Enabled = false;
            pictureBox_case.Image = null;
            pictureBox_motherboard.Image = null;
            pictureBox_processor.Image = null;
            pictureBox_psu.Image = null;
            pictureBox_ram.Image = null;
            pictureBox_storage.Image = null;
            label_case.Text = "";
            label_motherboard.Text = "";
            label_processor.Text = "";
            label_psu.Text = "";
            label_ram.Text = "";
            label_storage.Text = "";
            richTextBox_case.Text = "";
            richTextBox_motherboard.Text = "";
            richTextBox_processor.Text = "";
            richTextBox_psu.Text = "";
            richTextBox_ram.Text = "";
            richTextBox_storage.Text = "";
            richTextBox_guider.Text = "";
            comboBox_case.Items.Clear();
            comboBox_motherboard.Items.Clear();
            comboBox_processor.Items.Clear();
            comboBox_psu.Items.Clear();
            comboBox_ram.Items.Clear();
            comboBox_storage.Items.Clear();
            LoadProcessor();
        }

        private void LoadProcessor()
        {
            comboBox_processor.Items.Clear();
            panel_processor.Enabled = true;
            DataTable table = SqlCommandTable("Select Model from [Processor]");
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox_processor.Items.Add(table.Rows[i][0].ToString());
            richTextBox_guider.Text = "- Please choose your Processor to proceed next step.";
        }
        private void LoadMotherboard()
        {
            comboBox_motherboard.Items.Clear();
            panel_motherboard.Enabled = true;
            DataTable table = SqlCommandTable("Select Model from Motherboard where ([Socket Type]='" + Build.processor.SockerType + "' and [Memory Type]='" + Build.processor.MemoryType + "')");
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox_motherboard.Items.Add(table.Rows[i][0].ToString());
            for (int i = 0; i < table.Rows.Count; i++)
                if (label_motherboard.Text == table.Rows[i][0].ToString())
                    return;
            pictureBox_motherboard.Image = null;
            richTextBox_motherboard.Text = "";
            label_motherboard.Text = "";
            comboBox_motherboard.Text = "";
            richTextBox_guider.Text = "- Please choose your Motherboard to proceed next step.";
        }
        private void LoadMemory()
        {
            comboBox_ram.Items.Clear();
            panel_ram.Enabled = true;
            int length = 0;
            int speed = 0;
            DataTable table = SqlCommandTable("Select Model, [RAM Speed] from RAM where [RAM Type]='" + Build.processor.MemoryType + "'");
            for (int i = 0; i < table.Rows.Count; i++)
                if (checkBox1.Checked)
                {
                    length = table.Rows[i][1].ToString().IndexOf(" MHz");
                    speed = Convert.ToInt32(table.Rows[i][1] = table.Rows[i][1].ToString().Substring(0, length));
                    if (speed < Build.processor.MemorySpeed && speed < Build.motherboard.MemorySpeed)
                        comboBox_ram.Items.Add(table.Rows[i][0].ToString());
                }
                else
                    comboBox_ram.Items.Add(table.Rows[i][0].ToString());
            for (int i = 0; i < table.Rows.Count; i++)
                if (label_ram.Text == table.Rows[i][0].ToString())
                    return;
            pictureBox_ram.Image = null;
            richTextBox_ram.Text = "";
            label_ram.Text = "";
            comboBox_ram.Text = "";
            richTextBox_guider.Text = "- Please choose your RAM to proceed next step. Please note that if ram speed is higher than the max speed supported by Processor or Motherboard, the system will still working as normal, but your RAM will be downclocked. Please choose RAM with appropriate speed to avoid wasting resources."
                + "\n  + Max speed supported by your Motherboard: " + Build.motherboard.MemorySpeed + " MHz"
                + "\n  + Max speed supported by your Processor: " + Build.processor.MemorySpeed + " MHz"
                +"\n- We recommend choosing RAMs have speed equal or lower than supported speed by Processor and Motherboard to prevent wasting resource and money."
                +"\n-  Then, click \"Next\" button to continue";
        }
        private void LoadCase()
        {
            comboBox_case.Items.Clear();
            panel_case.Enabled = true;
            DataTable table = SqlCommandTable("Select Model from [Case] where [Motherboard Support] like '%" + Build.motherboard.FormFactor + "%'");
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox_case.Items.Add(table.Rows[i][0].ToString());
            for (int i = 0; i < table.Rows.Count; i++)
                if (label_case.Text == table.Rows[i][0].ToString())
                    return;
            pictureBox_case.Image = null;
            richTextBox_case.Text = "";
            label_case.Text = "";
            comboBox_case.Text = "";
            richTextBox_guider.Text = "- Please choose your Case to proceed next step. Please note that Graphic Card is optional and not supported in Auto Builder. If you have intend to install a Graphic Card, please consider the Maximum GPU length property when choosing";
        }
        private void LoadStorage()
        {
            comboBox_storage.Items.Clear();
            panel_storage.Enabled = true;
            string socket = Build.motherboard.StorageExpansion;
            for (int i = 0; i < socket.Length; i++)
            {
                if (socket[i] == ',')
                {
                    socket = socket.Substring(0, i) + "','" + socket.Substring(i + 2);
                    i = i + 1;
                }
            }
            DataTable table = SqlCommandTable("Select Model from [Storage] where [Interface] in ('" + socket + "')");
            for (int i = 0; i < table.Rows.Count; i++)
                comboBox_storage.Items.Add(table.Rows[i][0].ToString());
            for (int i = 0; i < table.Rows.Count; i++)
                if (label_storage.Text == table.Rows[i][0].ToString())
                    return;
            pictureBox_storage.Image = null;
            richTextBox_storage.Text = "";
            label_storage.Text = "";
            comboBox_storage.Text = "";
            richTextBox_guider.Text = "- Please choose your Storage Unit to proceed next step.";
        }
        private void LoadPSU()
        {
            comboBox_psu.Items.Clear();
            panel_psu.Enabled = true;
            int length = 0;
            DataTable table = new DataTable();
            table = SqlCommandTable("Select Model, [Power] from [Power Supply]");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                length = table.Rows[i][1].ToString().IndexOf(" W");
                table.Rows[i][1] = table.Rows[i][1].ToString().Substring(0, length);
            }
            for (int i = 0; i < table.Rows.Count; i++)
                if (Convert.ToInt32(table.Rows[i][1]) >= numericUpDown1.Value)
                    comboBox_psu.Items.Add(table.Rows[i][0].ToString());
            for (int i = 0; i < table.Rows.Count; i++)
                if (label_psu.Text == table.Rows[i][0].ToString())
                    return;
            pictureBox_psu.Image = null;
            richTextBox_psu.Text = "";
            label_psu.Text = "";
            comboBox_psu.Text = "";
            richTextBox_guider.Text = "- Please choose your Power Supply Unit to proceed next step. Please note that Graphic Card is optional and not supported in Auto Builder. If you have intend to install a Graphic Card, please consider the power consumption of GPU. We can help you narrow down by insert a number, the list will appear only PSUs that have Power property higher than it.";
        }
        private void button_next_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                tabControl1.SelectedIndex++;
            button_next.Enabled = false;
            button_previous.Enabled = true;
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                tabControl1.SelectedIndex--;
            button_previous.Enabled = false;
            button_next.Enabled = true;
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            form_reset();
        }

        private void comboBox_processor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_processor.Text))
            {
                richTextBox_processor.Text = "";
                Build.addProcessor(comboBox_processor.Text);
                label_processor.Text = Build.processor.Model;
                pictureBox_processor.Image = Image.FromFile(@"PC_Builder_Image\Processor\" + label_processor.Text + ".jpg");
                DataTable table = SqlCommandTable("Select * from Processor where Model='" + label_processor.Text + "'");
                for (int i = 0; i < table.Columns.Count - 1; i++)
                {
                    richTextBox_processor.Text += table.Columns[i].ColumnName + ": " + table.Rows[0][i].ToString() + "\n";

                }

            }
            LoadMotherboard();
            CompletionCheck();
        }

        private void comboBox_motherboard_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_motherboard.Text))
            {
                richTextBox_motherboard.Text = "";
                Build.addMotherboard(comboBox_motherboard.Text);
                label_motherboard.Text = Build.motherboard.Model;
                pictureBox_motherboard.Image = Image.FromFile(@"PC_Builder_Image\Motherboard\" + label_motherboard.Text + ".jpg");
                DataTable table = SqlCommandTable("Select * from Motherboard where Model='" + label_motherboard.Text + "'");
                for (int i = 0; i < table.Columns.Count - 1; i++)
                {
                    richTextBox_motherboard.Text += table.Columns[i].ColumnName + ": " + table.Rows[0][i].ToString() + "\n";

                }
            }
            LoadCase();
            LoadMemory();
            CompletionCheck();
        }

        private void comboBox_ram_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_ram.Text))
            {
                richTextBox_ram.Text = "";
                Build.addRAM(comboBox_ram.Text);
                label_ram.Text = Build.ram.Model;
                pictureBox_ram.Image = Image.FromFile(@"PC_Builder_Image\RAM\" + label_ram.Text + ".jpg");
                DataTable table = SqlCommandTable("Select * from RAM where Model='" + label_ram.Text + "'");
                for (int i = 0; i < table.Columns.Count - 1; i++)
                {
                    richTextBox_ram.Text += table.Columns[i].ColumnName + ": " + table.Rows[0][i].ToString() + "\n";

                }               
            }
            LoadCase();
            CompletionCheck();
        }
        private void CompletionCheck()
        {
            if (!string.IsNullOrEmpty(label_processor.Text)&& !string.IsNullOrEmpty(label_motherboard.Text) &&
                !string.IsNullOrEmpty(label_ram.Text) && !string.IsNullOrEmpty(label_case.Text) &&
                !string.IsNullOrEmpty(label_storage.Text) && !string.IsNullOrEmpty(label_psu.Text))
            {
                richTextBox_guider.Text = "- Congratulation! You have done a pre-build, now you can save and build up other optionals path.";
                isTheBuildCompleted = true;
            }
            else
                isTheBuildCompleted = false;
        }
        private void comboBox_case_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_case.Text))
            {
                richTextBox_case.Text = "";
                Build.addCase(comboBox_case.Text);
                label_case.Text = Build.cpuCase.Model;
                pictureBox_case.Image = Image.FromFile(@"PC_Builder_Image\Case\" + label_case.Text + ".jpg");
                DataTable table = SqlCommandTable("Select * from [Case] where Model='" + label_case.Text + "'");
                for (int i = 0; i < table.Columns.Count - 1; i++)
                {
                    richTextBox_case.Text += table.Columns[i].ColumnName + ": " + table.Rows[0][i].ToString() + "\n";

                }
            }
            LoadStorage();
            CompletionCheck();
        }

        private void comboBox_storage_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_storage.Text))
            {
                richTextBox_storage.Text = "";
                Build.addStorage(comboBox_storage.Text);
                label_storage.Text = Build.storage.Model;
                pictureBox_storage.Image = Image.FromFile(@"PC_Builder_Image\Storage\" + label_storage.Text + ".jpg");
                DataTable table = SqlCommandTable("Select * from [Storage] where Model='" + label_storage.Text + "'");
                for (int i = 0; i < table.Columns.Count - 1; i++)
                {
                    richTextBox_storage.Text += table.Columns[i].ColumnName + ": " + table.Rows[0][i].ToString() + "\n";

                }
            }
            LoadPSU();
            CompletionCheck();
        }

        private void comboBox_psu_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_psu.Text))
            {
                richTextBox_psu.Text = "";
                Build.addPSU(comboBox_psu.Text);
                label_psu.Text = Build.powerSupply.Model;
                pictureBox_psu.Image = Image.FromFile(@"PC_Builder_Image\Power Supply\" + label_psu.Text + ".jpg");
                DataTable table = SqlCommandTable("Select * from [Power Supply] where Model='" + label_psu.Text + "'");
                for (int i = 0; i < table.Columns.Count - 1; i++)
                {
                    richTextBox_psu.Text += table.Columns[i].ColumnName + ": " + table.Rows[0][i].ToString() + "\n";

                }
            }
            CompletionCheck();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LoadPSU();
        }

        private void button_build_Click(object sender, EventArgs e)
        {
            if(!isTheBuildCompleted)
            {
                DialogResult result = MessageBox.Show("The pre-build hasn't been completed yet, do you still want to proceed?", "Notify", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }
            SqlCommandExecuter("Update [Build List] set Processor = '', [Case] = '', Motherboard = '', [Case Cooler] = '', " +
                        "[CPU Cooler] = '', [Graphic Card] = '', RAM = '', Storage = '', [Power Supply] = '', Date = ''  where Name = 'temporary-cache'");
            SqlCommandExecuter("update [Build List] set Processor='"+label_processor.Text+"', Motherboard='"+label_motherboard.Text
                +"', RAM='"+label_ram.Text+"', [Case]='"+label_case.Text+"', Storage='"+label_storage.Text+"', [Power Supply]='"+label_psu.Text+"' where [Name]='temporary-cache'");
            PC_Building A = new PC_Building("Yes");
            A.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadMemory();
        }
    }
}
