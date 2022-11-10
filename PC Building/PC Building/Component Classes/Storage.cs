using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Building
{
    public class Storage
    {
        public string Category = "Storage";
        public string Model = "";
        public string Brand = "";
        public string Capacity = "";
        public string Type = "";
        public string RPM = "";
        public string Interface = "";
        public string CacheMemory = "";
        public string FormFactor = "";
        public double Price;
        public Storage(string ModelName)
        {
            Model = ModelName;
            string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Storage] where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            Capacity = Table.Rows[0][2].ToString();
            Type = Table.Rows[0][3].ToString();
            RPM = Table.Rows[0][4].ToString();
            Interface = Table.Rows[0][5].ToString();
            CacheMemory = Table.Rows[0][6].ToString();
            FormFactor = Table.Rows[0][7].ToString();
            Price = Math.Round(Convert.ToDouble(Table.Rows[0][8].ToString()), 1, MidpointRounding.AwayFromZero);
            sqlCon.Close();
        }
    }
}
