using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PC_Building
{
    public class Case
    {
        public string Category = "Case";
        public string Model = "";
        public string Brand = "";
        public string SidePanel = "";
        public string CarbinetType = "";
        public string Color = "";
        public string MotherboardSupport = "";
        public double MAXGPULength;
        public double CPUCoolerHeight;
        public string SupportPSUSize = "";
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
            sqlCmd.CommandText = "Select * from [Case] where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            SidePanel = Table.Rows[0][2].ToString();
            CarbinetType = Table.Rows[0][3].ToString();
            Color = Table.Rows[0][4].ToString();
            MotherboardSupport = Table.Rows[0][5].ToString();
            MAXGPULength =double.Parse(Table.Rows[0][6].ToString().Substring(0, Table.Rows[0][6].ToString().IndexOf(" mm")), CultureInfo.InvariantCulture);
            CPUCoolerHeight = double.Parse(Table.Rows[0][7].ToString().Substring(0, Table.Rows[0][7].ToString().IndexOf(" mm")), CultureInfo.InvariantCulture);
            SupportPSUSize = Table.Rows[0][8].ToString();
            Price=Convert.ToDouble(Table.Rows[0][9].ToString());
            sqlCon.Close();
        }
    }
}
