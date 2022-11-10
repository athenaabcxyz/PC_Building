using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public RAM(string ModelName)
        {
            Model = ModelName;
            string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
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
            RAMSpeed = Convert.ToInt32(Table.Rows[0][5].ToString());           
            Price = Math.Round(Convert.ToDouble(Table.Rows[0][6].ToString()), 1, MidpointRounding.AwayFromZero);
            sqlCon.Close();
        }
    }
}
