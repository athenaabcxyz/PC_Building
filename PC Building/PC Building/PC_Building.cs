using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Building
{
    public partial class PC_Building : Form
    {
        string strCon = @"Data Source=ATHENALAPTOP\SQLEXPRESS;Initial Catalog=CaseBuilder;Integrated Security=True";
        SqlConnection sqlCon = null;
        Building_Simulator Build = new Building_Simulator();
        public PC_Building()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DialogResult result = MessageBox.Show("Do you want to load the last build?", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable Table = new DataTable();
                sqlCmd.CommandText = "Update [Build List] set Processor = '', [Case] = '', Motherboard = '', [Case Cooler] = '', " +
                    "[CPU Cooler] = '', [Graphic Card] = '', RAM = '', Storage = '', [Power Supply] = '', Date = ''  where Name = 'temporary-cache'";
                sqlCmd.ExecuteNonQuery();
            }
            else
                formRefresh();
        }
        public void formRefresh(string A="temporary-cache")
        {
            richTextBox_BuildDetail.Text = "";
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Build List] where Name = '" + A + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            if (!string.IsNullOrEmpty(Table.Rows[0][3].ToString()))
            {
                Build.addMotherboard(Table.Rows[0][3].ToString());
                label_motherboardName.Text = Build.motherboard.Model;
                pictureBox_motherboard.Image = Image.FromFile(@"PC_Builder_Image\Motherboard\" + label_motherboardName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "Motherboard(mainboard): " + Build.motherboard.Model + "\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][1].ToString()))
            {
                Build.addProcessor(Table.Rows[0][1].ToString());
                label_cpuName.Text = Build.processor.Model;
                pictureBox_cpu.Image = Image.FromFile(@"PC_Builder_Image\Processor\" + label_cpuName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "Processor: " + Build.processor.Model + " @ " + Build.processor.BaseSpeed + " GHz (" + Build.processor.Core + " cores, "
                    + Build.processor.Thread + " threads)\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][7].ToString()))
            {
                Build.addRAM(Table.Rows[0][7].ToString());
                label_ramName.Text = Build.ram.Model;
                pictureBox_ram.Image = Image.FromFile(@"PC_Builder_Image\RAM\" + label_ramName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "RAM: " + Build.ram.Model + " " + Build.ram.Quantity + "\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][6].ToString()))
            {
                Build.addGraphicCard(Table.Rows[0][6].ToString());
                label_gpuName.Text = Build.graphicCard.Model;
                pictureBox_gpu.Image = Image.FromFile(@"PC_Builder_Image\Graphic Card\" + label_gpuName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "VGA: " + Build.graphicCard.Model + "\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][2].ToString()))
            {
                Build.addCase(Table.Rows[0][2].ToString());
                label_caseName.Text = Build.cpuCase.Model;
                pictureBox_case.Image = Image.FromFile(@"PC_Builder_Image\Case\" + label_caseName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "Case: " + Build.cpuCase.Model + "\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][4].ToString()))
            {
                Build.addCaseCooler(Table.Rows[0][4].ToString());
                label_caseCoolerName.Text = Build.caseCooler.Model;
                pictureBox_caseCooler.Image = Image.FromFile(@"PC_Builder_Image\Case Cooler\" + label_caseCoolerName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "Case Cooler: " + Build.caseCooler.Model + "\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][5].ToString()))
            {
                Build.addCPUCooler(Table.Rows[0][5].ToString());
                label_cpuCoolerName.Text = Build.cpuCooler.Model;
                pictureBox_cpuCooler.Image = Image.FromFile(@"PC_Builder_Image\CPU Cooler\" + label_cpuCoolerName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "CPU Cooler: " + Build.cpuCooler.Model + "\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][8].ToString()))
            {
                Build.addStorage(Table.Rows[0][8].ToString());
                label_storageName.Text = Build.storage.Model;
                pictureBox_storage.Image = Image.FromFile(@"PC_Builder_Image\Storage\" + label_storageName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "Storage: " + Build.storage.Model + " " + Build.storage.Capacity + " " + Build.storage.Type + "\n";
            }
            if (!string.IsNullOrEmpty(Table.Rows[0][9].ToString()))
            {
                Build.addPSU(Table.Rows[0][9].ToString());
                label_psuName.Text = Build.powerSupply.Model;
                pictureBox_psu.Image = Image.FromFile(@"PC_Builder_Image\Power Supply\" + label_psuName.Text + ".jpg");
                richTextBox_BuildDetail.Text += "PSU: " + Build.powerSupply.Model + "\n";
            }
        }
        private void ReloadForm(object sender, EventArgs e)
        {
            formRefresh();
        }
        private void button_addCaseCooler_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("Case Cooler");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addCPU_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("Processor");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addCPUCooler_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("CPU Cooler");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addPSU_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("Power Supply");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addMotherboard_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("Motherboard");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addStorage_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("Storage");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addRam_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("RAM");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addGPU_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("Graphic Card");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button_addCase_Click(object sender, EventArgs e)
        {
            AddComponentForm A = new AddComponentForm("Case");
            A.ReturnData += ReloadForm;
            A.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PriceCalculator A = new PriceCalculator(Build);
            A.Show();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (label_caseCoolerName.Text==""||label_caseName.Text==""||label_cpuCoolerName.Text==""||label_cpuName.Text==""
                ||label_gpuName.Text==""||label_motherboardName.Text==""||label_psuName.Text==""||label_ramName.Text==""||label_storageName.Text=="")
            {
                DialogResult result = MessageBox.Show("Your build is not completed. Do you still want to save this build?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sqlCon = new SqlConnection(strCon);
                    sqlCon.Open();
                    SqlCommand sqlCmd;
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    sqlCmd = sqlCon.CreateCommand();
                    DataTable Table = new DataTable();
                    if (string.IsNullOrEmpty(textBox_buildName.Text))
                    {
                        MessageBox.Show("Please input your build name.");
                        textBox_buildName.Focus();
                        return;
                    }
                    sqlCmd.CommandText = "Select Name from [Build List] where Name = '" + textBox_buildName.Text + "'";
                    Adapter.SelectCommand = sqlCmd;
                    Adapter.Fill(Table);
                    if (Table.Rows.Count > 0)
                    {
                        MessageBox.Show("The name of this build already existed, please choose another name.");
                        textBox_buildName.Focus();
                        return;
                    }
                    else
                    {
                        Table.Clear();
                        sqlCmd.CommandText = "insert into [Build List] values ('" + textBox_buildName.Text + "','" + label_cpuName.Text + "','" + label_caseName.Text + "','" + label_motherboardName.Text
                            + "','" + label_caseCoolerName.Text + "','" + label_cpuCoolerName.Text + "','" + label_gpuName.Text + "','" + label_ramName.Text + "','" + label_storageName.Text
                            + "','" + label_psuName.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Saved.");
                    }
                    sqlCon.Close();
                }
                else
                    return;
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            LoadBuild FormA=new LoadBuild();
            FormA.returnLoader += ReloadForm;
            FormA.Show();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (label_caseCoolerName.Text == "" || label_caseName.Text == "" || label_cpuCoolerName.Text == "" || label_cpuName.Text == ""
               || label_gpuName.Text == "" || label_motherboardName.Text == "" || label_psuName.Text == "" || label_ramName.Text == "" || label_storageName.Text == "")
            {
                MessageBox.Show("Your build is not completed. Please complete it before checking compatibility", "Warning");
                return;
            }
            else
            {
                CompatibilityLog A = new CompatibilityLog(Build.CompatibilityLog());
                A.Show();
            }
        }
    }
}
