using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PC_Building
{
    public partial class MainForm : Form
    {
        public bool isLiveChatOn = true;
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        string currentAmazonLink="";
        bool isTheBuildLiked = false;
        public MainForm()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            FillDatabase("");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadSharedBuild();
        }
        public void ShutDownLiveChat(object sender, EventArgs e)
        {
            isLiveChatOn = false;
        }
        public void FillDatabase(string a)
        {
            listView_Main.Clear();
            currentAmazonLink = "";
            button_openAmazon.Visible = false;
            button_openAmazon.Enabled = false;
            int ItemNumber = 0;           
            sqlCon.Open();
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
            sqlCon.Close();
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
            sqlCon.Open();
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
            sqlCon.Close();
        }

        private void button_Build_Click(object sender, EventArgs e)
        {
            PC_Building FormA = new PC_Building("");
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
            A.ShutDownLiveChat += ShutDownLiveChat;
            A.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AutoBuilder A = new AutoBuilder();
            A.Show();
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            tabControl_main.SelectedIndex = 0;
        }

        private void button_forum_Click(object sender, EventArgs e)
        {
            tabControl_main.SelectedIndex = 1;
        }

        private void LoadSharedBuild()
        {
            listView_buildList.Items.Clear();
            textBox_comments.Text = "";
            textBox_like.Text = "";
            textBox_sender.Text = "";
            button_save.BackgroundImage = Image.FromFile(@"PC_Builder_Image\Buttons\Unfavorite.png");
            button_like.BackgroundImage = Image.FromFile(@"PC_Builder_Image\Buttons\Unlike.png");
            richTextBox_comments.Text = "";
            richTextBox_decription.Text = "";
            label_buildName.Text = "";
            label_case.Text = "";
            label_caseCooler.Text = "";
            label_cpuCooler.Text = "";
            label_creator.Text = "";
            label_graphicCard.Text = "";
            label_motherboard.Text = "";
            label_processor.Text = "";
            label_psu.Text = "";
            label_ram.Text = "";
            label_storage.Text = "";
            pictureBox_case.Image = null;
            pictureBox_processor.Image = null;
            pictureBox_motherboard.Image = null;
            pictureBox_graphicCard.Image = null;
            pictureBox_ram.Image = null;
            pictureBox_storage.Image = null;
            pictureBox_psu.Image = null;
            pictureBox_caseCooler.Image = null;
            pictureBox_cpuCooler.Image = null;
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable table = new DataTable();
            sqlCmd.CommandText = "Select [ID],[Name],[Creator],[Like] from BuildShared";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var listViewItem = new ListViewItem();
                listViewItem.Text = table.Rows[i][0].ToString();
                listViewItem.SubItems.Add(table.Rows[i][1].ToString());
                listViewItem.SubItems.Add(table.Rows[i][2].ToString());
                listViewItem.SubItems.Add(table.Rows[i][3].ToString());
                listView_buildList.Items.Add(listViewItem);
            }
            isTheBuildLiked = false;
            sqlCon.Close();
        }
        private void LoadComments()
        {
            if (listView_buildList.SelectedItems.Count > 0)
            {
                richTextBox_comments.Text = "";
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable table = new DataTable();
                sqlCmd.CommandText = "Select * from SharedBuildInfo where ID =" + listView_buildList.SelectedItems[0].Text + " order by Sequence ASC";
                Adapter.SelectCommand = sqlCmd;
                Adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                        if (table.Rows[i][2].ToString() != "Anonymous" && textBox_sender.Text != table.Rows[i][2].ToString())
                            richTextBox_comments.AppendText(table.Rows[i][2].ToString() + ":\n", Color.Green);
                        else
                        if (table.Rows[i][2].ToString() == "Anonymous")
                            richTextBox_comments.AppendText(table.Rows[i][2].ToString() + ":\n", Color.Gray);
                        else
                            if (textBox_sender.Text == table.Rows[i][2].ToString())
                            richTextBox_comments.AppendText(table.Rows[i][2].ToString() + ":\n", Color.Cyan);
                    richTextBox_comments.AppendText(table.Rows[i][3].ToString() + "\n\n", Color.Black);
                }
                sqlCon.Close();
            }
        }

        private void listView_buildList_DoubleClick(object sender, EventArgs e)
        {
            if (listView_buildList.SelectedItems.Count > 0)
            {
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable table = new DataTable();
                sqlCmd.CommandText = "Select * from BuildShared where ID =" + listView_buildList.SelectedItems[0].Text + "";
                Adapter.SelectCommand = sqlCmd;
                Adapter.Fill(table);
                label_buildName.Text = table.Rows[0][1].ToString();
                label_creator.Text = table.Rows[0][2].ToString();
                richTextBox_decription.Text = table.Rows[0][3].ToString();
                textBox_like.Text = table.Rows[0][4].ToString();
                label_processor.Text = table.Rows[0][5].ToString();
                label_case.Text = table.Rows[0][6].ToString();
                label_motherboard.Text = table.Rows[0][7].ToString();
                label_caseCooler.Text = table.Rows[0][8].ToString();
                label_cpuCooler.Text = table.Rows[0][9].ToString();
                label_graphicCard.Text = table.Rows[0][10].ToString();
                label_ram.Text = table.Rows[0][11].ToString();
                label_storage.Text = table.Rows[0][12].ToString();
                label_psu.Text = table.Rows[0][13].ToString();
                sqlCon.Close();
                LoadComments();
                if (!string.IsNullOrEmpty(label_case.Text))
                pictureBox_case.Image = Image.FromFile(@"PC_Builder_Image\Case\" + label_case.Text + ".jpg");
                else
                    pictureBox_case.Image = null;
                if (!string.IsNullOrEmpty(label_processor.Text))
                pictureBox_processor.Image = Image.FromFile(@"PC_Builder_Image\Processor\" + label_processor.Text + ".jpg");
                else
                    pictureBox_processor.Image = null;
                if (!string.IsNullOrEmpty(label_motherboard.Text))
                pictureBox_motherboard.Image = Image.FromFile(@"PC_Builder_Image\Motherboard\" + label_motherboard.Text + ".jpg");
                else
                    pictureBox_motherboard.Image = null;
                if (!string.IsNullOrEmpty(label_graphicCard.Text))
                pictureBox_graphicCard.Image = Image.FromFile(@"PC_Builder_Image\Graphic Card\" + label_graphicCard.Text + ".jpg");
                else
                    pictureBox_graphicCard.Image = null;
                if (!string.IsNullOrEmpty(label_ram.Text))
                pictureBox_ram.Image = Image.FromFile(@"PC_Builder_Image\RAM\" + label_ram.Text + ".jpg");
                else
                    pictureBox_ram.Image = null;
                if (!string.IsNullOrEmpty(label_storage.Text))
                pictureBox_storage.Image = Image.FromFile(@"PC_Builder_Image\Storage\" + label_storage.Text + ".jpg");
                else
                    pictureBox_storage.Image = null;
                if (!string.IsNullOrEmpty(label_psu.Text))
                pictureBox_psu.Image = Image.FromFile(@"PC_Builder_Image\Power Supply\" + label_psu.Text + ".jpg");
                else
                    pictureBox_psu.Image = null;
                if (!string.IsNullOrEmpty(label_caseCooler.Text))
                pictureBox_caseCooler.Image = Image.FromFile(@"PC_Builder_Image\Case Cooler\" + label_caseCooler.Text + ".jpg");
                else
                    pictureBox_caseCooler.Image = null;
                if (!string.IsNullOrEmpty(label_cpuCooler.Text))
                pictureBox_cpuCooler.Image = Image.FromFile(@"PC_Builder_Image\CPU Cooler\" + label_cpuCooler.Text + ".jpg");
                else
                    pictureBox_cpuCooler.Image = null;
                if(SavedCheck())
                    button_save.BackgroundImage = Image.FromFile(@"PC_Builder_Image\Buttons\Favorite.png");
                else
                    button_save.BackgroundImage = Image.FromFile(@"PC_Builder_Image\Buttons\Unfavorite.png");
            }
        }

        private void listView_buildList_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTheBuildLiked = false;
        }

        private void button_like_Click(object sender, EventArgs e)
        {
            if (!isTheBuildLiked)
            {
                isTheBuildLiked = true;
                textBox_like.Text = Convert.ToString(Convert.ToInt32(textBox_like.Text) + 1);
                button_like.BackgroundImage=Image.FromFile(@"PC_Builder_Image\Buttons\Like.png");
            }
            else
            {
                isTheBuildLiked = false;
                textBox_like.Text = Convert.ToString(Convert.ToInt32(textBox_like.Text) + -1);
                if (Convert.ToInt32(textBox_like.Text) < 0)
                    textBox_like.Text = "0";
                button_like.BackgroundImage = Image.FromFile(@"PC_Builder_Image\Buttons\Unlike.png");
            }
        }

        private bool SavedCheck()
        {

            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable table = new DataTable();
            sqlCmd.CommandText = "Select * from [Build List] where ([Name]='" + label_buildName.Text + "' and [Processor]='" + label_processor.Text +
                "' and [Motherboard]='" + label_motherboard.Text + "' and [Case]='" + label_case.Text + "' and [RAM]='" + label_ram.Text + "' and [Storage]='"
                + label_storage.Text + "' and [Graphic Card]='" + label_graphicCard.Text + "' and [Case Cooler]='" + label_caseCooler.Text + "' and [CPU Cooler]='"
                + label_cpuCooler.Text + "' and [Power Supply]='"+label_psu.Text+"')";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(table);
            sqlCon.Close();
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(SavedCheck())
            {
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = "delete from [Build List] where [Name]='" + label_buildName.Text + "'";
                sqlCmd.ExecuteNonQuery();
                button_save.BackgroundImage = Image.FromFile(@"PC_Builder_Image\Buttons\Unfavorite.png");
                sqlCon.Close();
            }
            else
            {
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = "Insert into [Build List] values('" + label_buildName.Text + "','" + label_processor.Text +
                "','" + label_case.Text + "','" + label_motherboard.Text + "','" + label_caseCooler.Text + "','"
                + label_cpuCooler.Text + "','" + label_graphicCard.Text + "','" + label_ram.Text + "','"
                + label_storage.Text + "','" + label_psu.Text + "','" + DateTime.Now + "')";
                sqlCmd.ExecuteNonQuery();
                button_save.BackgroundImage = Image.FromFile(@"PC_Builder_Image\Buttons\Favorite.png");
                sqlCon.Close();
            }
        }

        private void button_rebuild_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandText = "Update [Build List] set Processor = '', [Case] = '', Motherboard = '', [Case Cooler] = '', " +
                       "[CPU Cooler] = '', [Graphic Card] = '', RAM = '', Storage = '', [Power Supply] = '', Date = ''  where Name = 'temporary-cache'";
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText= "update [Build List] set [Processor]='" + label_processor.Text +
                "' , [Motherboard]='" + label_motherboard.Text + "' , [Case]='" + label_case.Text + "' , [RAM]='" + label_ram.Text + "' , [Storage]='"
                + label_storage.Text + "' , [Graphic Card]='" + label_graphicCard.Text + "' , [Case Cooler]='" + label_caseCooler.Text + "' , [CPU Cooler]='"
                + label_cpuCooler.Text + "' , [Power Supply]='" + label_psu.Text + "' where [Name]='temporary-cache'";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            PC_Building A = new PC_Building("Yes");
            A.Show();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (listView_buildList.SelectedItems.Count > 0)
            {
                string name = "";
                if (textBox_sender.Text == "")
                    name = "Anonymous";
                else
                    name = textBox_sender.Text;
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable table = new DataTable();
                sqlCmd.CommandText = "Select * from SharedBuildInfo where ID=" + listView_buildList.SelectedItems[0].Text;
                Adapter.SelectCommand = sqlCmd;
                Adapter.Fill(table);
                int ID = table.Rows.Count + 1;
                sqlCmd.CommandText = "insert into SharedBuildInfo values(" + listView_buildList.SelectedItems[0].Text + ", " + ID + ",'" + name + "','" + textBox_comments.Text + "')";
                sqlCmd.ExecuteNonQuery();
                textBox_comments.Text = "";
                sqlCon.Close();
                LoadComments();
            }
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            LoadSharedBuild();
        }

        private void openLiveChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isLiveChatOn)
            {
                return;
            }
            else
            {
                LiveChat A = new LiveChat();
                A.ShutDownLiveChat += ShutDownLiveChat;
                A.Show();
                isLiveChatOn = true;
            }
        }
    }
}