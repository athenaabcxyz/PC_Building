﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace PC_Building
{
    public class Processor
    {
        public string Category = "Processor";
        public string Model = "";
        public string Brand = "";
        public int Core;
        public int Thread;
        public string SockerType = "";
        public string MemoryType = "";
        public int MemorySpeed;
        public double BaseSpeed;
        public double TurboSpeed;
        public double MaxPowerConsumption;
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
            sqlCmd.CommandText = "Select * from Processor where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            Core = Convert.ToInt32(Table.Rows[0][2].ToString());
            Thread = Convert.ToInt32(Table.Rows[0][3].ToString());
            SockerType = Table.Rows[0][4].ToString();
            MemoryType = Table.Rows[0][5].ToString();
            MemorySpeed = Convert.ToInt32(Table.Rows[0][6].ToString().Substring(0, Table.Rows[0][6].ToString().IndexOf(" MHz")));
            BaseSpeed = double.Parse(Table.Rows[0][7].ToString().Substring(0, Table.Rows[0][7].ToString().IndexOf(" GHz")), CultureInfo.InvariantCulture);
            TurboSpeed = double.Parse(Table.Rows[0][8].ToString().Substring(0, Table.Rows[0][8].ToString().IndexOf(" GHz")), CultureInfo.InvariantCulture);
            MaxPowerConsumption = double.Parse(Table.Rows[0][9].ToString().Substring(0, Table.Rows[0][9].ToString().IndexOf(" W")), CultureInfo.InvariantCulture);
            Price = Convert.ToDouble(Table.Rows[0][10].ToString());
            sqlCon.Close();
        }
    }
}
