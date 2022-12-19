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
    public partial class AddComponentForm : Form
    {
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        public AddComponentForm(string ComponentA)
        {          
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            label_component.Text = ComponentA;
            LoadComboBox();
        }
        public void LoadComboBox(string a = "")
        {
            comboBox_component.Items.Clear();  
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select Model from [" + label_component.Text+ "] where Model like '%" + a + "%'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                comboBox_component.Items.Add(Table.Rows[i][0].ToString());
            }
            sqlCon.Close();
        }

        public event EventHandler ReturnData;
        public void button_confirm_Click(object sender, EventArgs e)
        {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable Table = new DataTable();
                sqlCmd.CommandText = "Update [Build List] set [" + label_component.Text + "] = '" + comboBox_component.Text + "' where Name = 'temporary-cache'";
                sqlCmd.ExecuteNonQuery();
                ReturnData(this, new EventArgs());
                this.Close();

        }

        private void comboBox_component_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadComboBox(comboBox_component.Text);
        }

        private void comboBox_component_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBox_Detail.Text = "";
            pictureBox1.Image = Image.FromFile(@"PC_Builder_Image\" + label_component.Text + @"\" + comboBox_component.Text + ".jpg");
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [" + label_component.Text + "] where Model = '" + comboBox_component.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Columns.Count; i++)
            {
                richTextBox_Detail.Text += Table.Columns[i].ColumnName + ": " + Table.Rows[0][i].ToString() + "\n";

            }
        }
    }
}
