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
    public partial class LoadBuild : Form
    {
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        public LoadBuild()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            button_delete.Enabled = false;
            button_load.Enabled = false;
            LoadAvailableBuild();
        }
        private void LoadAvailableBuild()
        {
            listView1.Items.Clear();
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select Name, Date from [Build List] where Name <> 'temporary-cache'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i=0; i < Table.Rows.Count; i++)
            {
                var Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add(Table.Rows[i][1].ToString());
                listView1.Items.Add(Item);
            }
            sqlCon.Close();
        }
        public event EventHandler returnLoader;
        public void button_load_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                DialogResult result = MessageBox.Show("Do you want to load this build?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                    SqlCommand sqlCmd;
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    sqlCmd = sqlCon.CreateCommand();
                    DataTable Table = new DataTable();
                    sqlCmd.CommandText = "Select * from [Build List] where Name = '" + listView1.SelectedItems[0].Text + "'";
                    Adapter.SelectCommand = sqlCmd;
                    Adapter.Fill(Table);
                    sqlCmd.CommandText = "update [Build List] set [Processor]='" + Table.Rows[0][1].ToString() + "', [Case] ='" + Table.Rows[0][2].ToString() +
                        "', [Motherboard]='" + Table.Rows[0][3].ToString() + "', [Case Cooler]='" + Table.Rows[0][4].ToString() +
                        "', [CPU Cooler]='" + Table.Rows[0][5].ToString() + "', [Graphic Card]='" + Table.Rows[0][6].ToString() + "', [RAM]='" + Table.Rows[0][7].ToString() +
                        "', [Storage]='" + Table.Rows[0][8].ToString() + "',[Power Supply]='" + Table.Rows[0][9].ToString() + "' where Name = 'temporary-cache'";
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    returnLoader(this, new EventArgs());
                    this.Close();
                }
            }  
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this build?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                    SqlCommand sqlCmd;
                    sqlCmd = sqlCon.CreateCommand();
                    sqlCmd.CommandText = "delete from [Build List] where Name = '" + listView1.SelectedItems[0].Text + "'";
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    LoadAvailableBuild();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_delete.Enabled = true;
            button_load.Enabled = true;
        }
    }
}
