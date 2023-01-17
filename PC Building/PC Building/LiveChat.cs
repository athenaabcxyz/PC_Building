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
    public partial class LiveChat : Form
    {
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        public LiveChat()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            sqlCon = new SqlConnection(strCon);
            LoadMessage();
        }
        void LoadMessage()
        {
            listView_commentlist.Items.Clear();
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
                listView_commentlist.Items.Add(table.Rows[i][1] + ": " + table.Rows[i][2]);
            }
            sqlCon.Close();
            button1.Enabled = false;
            if (listView_commentlist.Items.Count > 0)
                listView_commentlist.Items[listView_commentlist.Items.Count - 1].EnsureVisible();
        }
        private void button1_Click(object sender, EventArgs e)
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
                name=textBox1.Text;
            string A = richTextBox1.Text;
            for (int k = 0; k < A.Length; k++)
            {
                if (A[k] == '\'')
                {
                    A = A.Substring(0, k) + "'" + A.Substring(k);
                    k++;
                }
            }
            sqlCmd.CommandText = "Insert into LiveChat values(" + Number + ", N'" + name + "',N'" + A + "')";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            richTextBox1.Clear();
            LoadMessage();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void LiveChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to close the Live Chat section?", "Notice", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }

}
