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
    public class RAM
    {
        public string Category = "RAM";
        public string Model = "";
        public string Brand = "";
        public string RAMSize = "";
        public string Quantity = "";
        public string RAMType = "";
        public int RAMSpeed;        
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
            sqlCmd.CommandText = "Select * from [RAM] where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            RAMSize = Table.Rows[0][2].ToString();
            Quantity = Table.Rows[0][3].ToString();
            RAMType = Table.Rows[0][4].ToString();
            RAMSpeed = Convert.ToInt32(Table.Rows[0][5].ToString().Substring(0, Table.Rows[0][5].ToString().IndexOf(" MHz")));
            Price = Convert.ToDouble(Table.Rows[0][6].ToString());
            sqlCon.Close();
        }
    }
}
