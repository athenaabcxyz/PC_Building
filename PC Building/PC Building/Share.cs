﻿using System;
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
namespace PC_Building
{
    public partial class Share : Form
    {
        string currentUser = "";
        Building_Simulator Build;
        string strCon = ConfigurationManager.ConnectionStrings["CaseBuilder"].ConnectionString;
        SqlConnection sqlCon = null;
        public Share(Building_Simulator A, string user)
        {
            InitializeComponent();
            currentUser = user;
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
            if (!String.IsNullOrEmpty(currentUser))
            {
                textBox2.ReadOnly= true;
                sqlCmd.CommandText = "Select CustomeName from UserInfo where UserName ='" + currentUser + "'";
                Adapter.SelectCommand = sqlCmd;
                Adapter.Fill(table);
                textBox2.Text = table.Rows[0][0].ToString();
            }
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
