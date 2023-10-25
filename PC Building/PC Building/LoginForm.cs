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
    public partial class LoginForm : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["CaseBuilder"].ConnectionString;
        SqlConnection sqlCon = null;
        public LoginForm()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public event Action<string> OnLogin;

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select * from UserInfo where UserName = '" + textBox_username.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count < 1)
            {
                MessageBox.Show("Wrong username or password. Please try again.");
            }
            else
            {
                if (Table.Rows[0][1].ToString() == textBox_password.Text)
                {
                    OnLogin?.Invoke(textBox_username.Text);
                    MessageBox.Show("Logged in successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password. Please try again.");
                }
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            //Update Processor           
            sqlCmd.CommandText = "Select * from UserInfo where UserName = '" + textBox_re_username.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (Table.Rows.Count >= 1)
            {
                MessageBox.Show("Username already existed.");
            }
            else
            {
                if (textBox_re_pass.Text == textBox_re_repass.Text)
                {
                    sqlCmd.CommandText = "insert into UserInfo values('" + textBox_re_username.Text + "','" + textBox_re_pass.Text + "','" + textBox_customName.Text + "')";
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully.");
                }
                else
                {
                    MessageBox.Show("Password mismatch.");
                }
            }
        }
    }
}
