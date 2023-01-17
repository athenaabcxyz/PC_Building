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
    public partial class Share : Form
    {
        Building_Simulator Build;
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Share(Building_Simulator A)
        {
            InitializeComponent();
            sqlCon = new SqlConnection(strCon);
            Build = A;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable table = new DataTable();
            sqlCmd.CommandText = "Select * from BuildShared";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(table);
            int ID = table.Rows.Count + 1;
            sqlCmd.CommandText = "insert into BuildShared values(" + ID + ",'" + textBox1.Text + "','" + textBox2.Text + "',N'" + richTextBox1.Text
                + "',0,'" + Build.processor.Model + "','" + Build.cpuCase.Model + "','" + Build.motherboard.Model + "','" + Build.caseCooler.Model
                + "','" + Build.cpuCooler.Model + "','" + Build.graphicCard.Model + "','" + Build.ram.Model + "','" + Build.storage.Model + "','" + Build.powerSupply.Model + "')";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            this.Close();
        }
    }
}
