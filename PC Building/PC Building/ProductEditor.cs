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

namespace PC_Building
{
    public partial class ProductEditor : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["CaseBuilder"].ConnectionString;
        SqlConnection sqlCon = null;
        public event EventHandler returnLoader;
        public ProductEditor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            button_delete.Enabled = false;
            button_edit.Enabled = false;
            LoadProducts();
        }
        private void LoadProducts()
        {
            listView1.Items.Clear();
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select Model from [Processor]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("Processor");
                listView1.Items.Add(Item);
            }
            Table.Clear();

            sqlCmd.CommandText = "Select Model from [Motherboard]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("Motherboard");
                listView1.Items.Add(Item);
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [CPU Cooler]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("CPU Cooler");
                listView1.Items.Add(Item);
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Case]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("Case");
                listView1.Items.Add(Item);
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Graphic Card]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("Graphic Card");
                listView1.Items.Add(Item);
            }
            Table.Clear();

            sqlCmd.CommandText = "Select Model from [RAM]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("RAM");
                listView1.Items.Add(Item);
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Storage]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("Storage");
                listView1.Items.Add(Item);
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Case Cooler]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("Case Cooler");
                listView1.Items.Add(Item);
            }
            Table.Clear();
            sqlCmd.CommandText = "Select Model from [Power Supply]";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Table.Rows[i][0].ToString();
                Item.SubItems.Add("Power Supply");
                listView1.Items.Add(Item);
            }
            Table.Clear();
            sqlCon.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                button_delete.Enabled = true;

            }
            else
            {
                button_delete.Enabled = false;
            }
            if (listView1.SelectedItems.Count == 1)
            {
                button_edit.Enabled = true;
            }
            else
            {
                button_edit.Enabled = false;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.updateForm += ReloadForm;
            addProduct.Show();
        }
        public void ReloadForm(object sender, EventArgs e)
        {
            LoadProducts();
            returnLoader(this, new EventArgs());
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.updateForm += ReloadForm;
            addProduct.LoadEditItem(listView1.SelectedItems[0].Text, listView1.SelectedItems[0].SubItems[1].Text);
            addProduct.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected product(s)?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                    SqlCommand sqlCmd;
                    sqlCmd = sqlCon.CreateCommand();
                    sqlCmd.CommandText = "delete from [" + listView1.SelectedItems[i].SubItems[1].Text + "] where Model ='" + listView1.SelectedItems[i].Text + "'";
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }


    }
}
