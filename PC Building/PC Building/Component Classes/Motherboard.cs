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
    public class Motherboard
    {
        public string Category = "Motherboard";
        public string Model = "";
        public string Brand = "";
        public string Chipset = "";
        public string FormFactor = "";
        public string SockerType = "";
        public int MemorySlot;
        public string MemoryType = "";
        public int MemorySpeed;
        public string StorageExpansion = "";
        public bool MultiGPUSupport = false;
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
            sqlCmd.CommandText = "Select * from Motherboard where Model = '" + Model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            Brand = Table.Rows[0][1].ToString();
            Chipset = Table.Rows[0][2].ToString();
            FormFactor = Table.Rows[0][3].ToString();
            SockerType = Table.Rows[0][4].ToString();
            MemorySlot = Convert.ToInt32(Table.Rows[0][5].ToString());
            MemoryType = Table.Rows[0][6].ToString();
            MemorySpeed = Convert.ToInt32(Table.Rows[0][7].ToString().Substring(0, Table.Rows[0][7].ToString().IndexOf(" MHz")));
            StorageExpansion = Table.Rows[0][8].ToString();
            if (Table.Rows[0][9].ToString() == "Yes")
                MultiGPUSupport = true;
            Price = Convert.ToDouble(Table.Rows[0][10].ToString());
            sqlCon.Close();
        }
    }
}
