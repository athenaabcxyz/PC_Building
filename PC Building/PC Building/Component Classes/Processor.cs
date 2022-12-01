using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
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
            MemorySpeed = Convert.ToInt32(Table.Rows[0][6].ToString());
            BaseSpeed = double.Parse(Table.Rows[0][7].ToString(), CultureInfo.InvariantCulture);
            TurboSpeed = double.Parse(Table.Rows[0][8].ToString(), CultureInfo.InvariantCulture);
            MaxPowerConsumption = double.Parse(Table.Rows[0][9].ToString(), CultureInfo.InvariantCulture);
            Price = Convert.ToDouble(Table.Rows[0][10].ToString());
            sqlCon.Close();
        }
    }
}
