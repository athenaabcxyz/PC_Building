using System;
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
    public class Power_Supply
    {
        public string Category = "Power Supply";
        public string Model = "";
        public string Brand = "";
        public string Power = "";
        public string Efficiency = "";
        public string Color = "";
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
            sqlCmd.CommandText = "Select * from [Power Supply] where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            Power = Table.Rows[0][2].ToString();
            Efficiency = Table.Rows[0][3].ToString();
            Color = Table.Rows[0][4].ToString();
            Price = Convert.ToDouble(Table.Rows[0][5].ToString());
            sqlCon.Close();
        }
    }
}
