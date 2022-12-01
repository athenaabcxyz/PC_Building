using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PC_Building
{
    public class CPU_Cooler
    {
        public string Category = "CPU Cooler";
        public string Model = "";
        public string Brand = "";
        public string FanRPM = "";
        public string NoiseLV = "";
        public string Color = "";
        public double Price;
        public void LoadProduct(string ModelName)
        {
            Model = ModelName;
            string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [CPU Cooler] where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            FanRPM = Table.Rows[0][2].ToString();
            NoiseLV = Table.Rows[0][3].ToString();
            Color = Table.Rows[0][4].ToString();
            Price = Convert.ToDouble(Table.Rows[0][5].ToString());
            sqlCon.Close();
        }
    }
}
