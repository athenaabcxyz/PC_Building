﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Configuration;

namespace PC_Building
{
    public class Case_Cooler
    {
        public string Category = "Case Cooler";
        public string Model = "";
        public string Brand = "";
        public string FanRPM = "";
        public string AirFlow = "";
        public string NoiseLV = "";
        public double Price;
        public void LoadProduct(string ModelName)
        {
            Model = ModelName;
            string strCon = ConfigurationManager.ConnectionStrings["CaseBuilder"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Case Cooler] where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            FanRPM = Table.Rows[0][2].ToString();
            AirFlow = Table.Rows[0][3].ToString();
            NoiseLV = Table.Rows[0][4].ToString();
            Price = Convert.ToDouble(Table.Rows[0][5].ToString());
            sqlCon.Close();
        }
    }
}
