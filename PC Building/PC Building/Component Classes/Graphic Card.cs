using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Building
{
    public class Graphic_Card
    {

        public string Category = "Graphic Card";
        public string Model = "";
        public string Brand = "";
        public string Memory = "";
        public string MemoryInterface = "";
        public string Length = "";
        public string Interface = "";
        public string Chipset = "";
        public double MaxPowerConsumption;
        public double Price;
        public Graphic_Card(string ModelName)
        {
            Model = ModelName;
            string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Graphic Card] where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            Memory = Table.Rows[0][2].ToString();
            MemoryInterface = Table.Rows[0][3].ToString();
            Length = Table.Rows[0][4].ToString();
            Interface = Table.Rows[0][5].ToString();
            Chipset = Table.Rows[0][6].ToString();
            MaxPowerConsumption = Math.Round(Convert.ToDouble(Table.Rows[0][7].ToString()), 1, MidpointRounding.AwayFromZero);
            Price = Math.Round(Convert.ToDouble(Table.Rows[0][8].ToString()), 1, MidpointRounding.AwayFromZero);
            sqlCon.Close();
        }
    }
}
