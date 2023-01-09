using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace PC_Building
{
    public partial class MainForm : Form
    {       
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        string currentAmazonLink="";
        public MainForm()
        {
            InitializeComponent();
            FillDatabase("");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        public void OpenConnection()
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                if(sqlCon.State==ConnectionState.Closed)
                {
                    sqlCon.Open();               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CloseConnection()
        {
            if (sqlCon != null && sqlCon.State==ConnectionState.Open)
                sqlCon.Close();
        }
        public void FillDatabase(string a)
        {
            listView_Main.Clear();
            currentAmazonLink = "";
            button_openAmazon.Visible = false;
            button_openAmazon.Enabled = false;
            int ItemNumber = 0;           
            OpenConnection();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select Model from Processor where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;          
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[0];
            }
            Table.Clear();
            //Update Motherboard
            sqlCmd.CommandText = "Select Model from Motherboard where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[1];
            }
            Table.Clear();
            //Update CPU Cooler
            sqlCmd.CommandText = "Select Model from [CPU Cooler] where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[2];
            }
            Table.Clear();
            //Update Case
            sqlCmd.CommandText = "Select Model from [Case] where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[3];
            }
            Table.Clear();
            //Update Graphic Card
            sqlCmd.CommandText = "Select Model from [Graphic Card] where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[4];
            }
            Table.Clear();
            //Update RAM
            sqlCmd.CommandText = "Select Model from RAM where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[5];
            }
            Table.Clear();
            //Update Storage
            sqlCmd.CommandText = "Select Model from Storage where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[6];
            }
            Table.Clear();
            //Update Case Cooler
            sqlCmd.CommandText = "Select Model from [Case Cooler] where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[7];
            }
            Table.Clear();
            //Update PSU
            sqlCmd.CommandText = "Select Model from [Power Supply] where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                listView_Main.Items.Add(Table.Rows[i][0].ToString(), Table.Rows[i][0].ToString() + ".jpg");
                ItemNumber++;
                listView_Main.Items[listView_Main.FindItemWithText(Table.Rows[i][0].ToString()).Index].Group = listView_Main.Groups[8];
            }
            Table.Clear();
            CloseConnection();
        }

        private void comboBox_Category_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_Category.SelectedIndex == 9)
            {
                for (int i = 0; i < listView_Main.Groups.Count; i++)
                    listView_Main.Groups[i].CollapsedState = ListViewGroupCollapsedState.Expanded;
            }
            else
            {
                for (int i = 0; i < listView_Main.Groups.Count; i++)
                {
                    if (i != comboBox_Category.SelectedIndex)
                        listView_Main.Groups[i].CollapsedState = ListViewGroupCollapsedState.Collapsed;
                    else
                        listView_Main.Groups[i].CollapsedState = ListViewGroupCollapsedState.Expanded;
                }
            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            FillDatabase(textBox_Search.Text);                
        }

        private void listView_Main_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_Main.FocusedItem == null)
                return;
            richTextBox_Detail.Text = "";
            pictureBox_Illu.Image = Image.FromFile(@"PC_Builder_Image\" + listView_Main.FocusedItem.Group.Header + @"\" + listView_Main.FocusedItem.Text + ".jpg");
            OpenConnection();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [" + listView_Main.FocusedItem.Group.Header + "] where Model = '" + listView_Main.FocusedItem.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Columns.Count-1; i++)
            {
                richTextBox_Detail.Text += Table.Columns[i].ColumnName + ": " + Table.Rows[0][i].ToString() + "\n";

            }
            currentAmazonLink = Table.Rows[0][Table.Columns.Count - 1].ToString();
            if (!string.IsNullOrEmpty(currentAmazonLink))
            {
                button_openAmazon.Visible = true;
                button_openAmazon.Enabled = true;
            }
        }

        private void button_Build_Click(object sender, EventArgs e)
        {
            PC_Building FormA = new PC_Building();
            FormA.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView_Main.SelectedItems.Count > 0)
            {
                var ps = new ProcessStartInfo(currentAmazonLink)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LiveChat A = new LiveChat();
            A.Show();
        }
    }
}