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
                getCurrentModelName(tabControl_component.SelectedIndex);
                label_currentComponent.Text = tabControl_component.SelectedTab.Text;
            }
            else
                formRefresh();
        }
        public void formRefresh(string A = "temporary-cache")
        {
            richTextBox_BuildDetail.Text = "";
            resetComponent();
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
            getCurrentModelName(tabControl_component.SelectedIndex);
            label_currentComponent.Text = tabControl_component.SelectedTab.Text;
            LoadMotherboard();
            LoadProcessor();
            LoadMemory();
            LoadPSU();
            LoadCase();
            LoadGPU();
            LoadCaseCooler();
            LoadcpuCooler();
            LoadStorage();
        }
        private void ReloadForm(object sender, EventArgs e)
        {
            formRefresh();
        }

        public void resetComponent()
        {
            pictureBox_case.Image = null;
            pictureBox_caseCooler.Image = null;
            pictureBox_cpu.Image = null;
            pictureBox_cpuCooler.Image = null;
            pictureBox_gpu.Image = null;
            pictureBox_motherboard.Image = null;
            pictureBox_psu.Image= null;
            pictureBox_ram.Image = null;
            pictureBox_storage.Image = null;
            label_caseCoolerName.Text = "";
            label_cpuCoolerName.Text = "";
            label_cpuName.Text = "";
            label_motherboardName.Text = "";
            label_gpuName.Text = "";
            label_storageName.Text = "";
            label_caseName.Text = "";
            label_ramName.Text = "";
            label_psuName.Text = "";
        }
        public void getCurrentModelName(int i)
        {
            switch (i)
            {
                case 0:
                    label_modelName.Text = label_motherboardName.Text;
                break;
                case 1:
                    label_modelName.Text = label_cpuName.Text;
                    break;
                case 2:
                    label_modelName.Text = label_ramName.Text;
                    break;
                case 3:
                    label_modelName.Text = label_psuName.Text;
                    break;
                case 4:
                    label_modelName.Text = label_caseName.Text;
                    break;
                case 5:
                    label_modelName.Text = label_gpuName.Text;
                    break;
                case 6:
                    label_modelName.Text = label_caseCoolerName.Text;
                    break;
                case 7:
                    label_modelName.Text = label_storageName.Text;
                    break;
                case 8:
                    label_modelName.Text = label_cpuCoolerName.Text;
                    break;
            }

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
            if (label_caseCoolerName.Text == "" || label_caseName.Text == "" || label_cpuCoolerName.Text == "" || label_cpuName.Text == ""
                || label_gpuName.Text == "" || label_motherboardName.Text == "" || label_psuName.Text == "" || label_ramName.Text == "" || label_storageName.Text == "")
            {
                DialogResult result = MessageBox.Show("Your build is not completed. Do you still want to save this build?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
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
                DialogResult dialog = MessageBox.Show("The name of this build already existed, do you want to overwrite?", "Warning", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                    return;
                else
                {
                    Table.Clear();
                    sqlCmd.CommandText = "Update [Build List] set [Processor]= '" + label_cpuName.Text + "', [Case]='" + label_caseName.Text + "', [Motherboard]='" + label_motherboardName.Text
                        + "',[Case Cooler]='" + label_caseCoolerName.Text + "', [CPU Cooler]= '" + label_cpuCoolerName.Text + "',[Graphic Card]='" + label_gpuName.Text + "',[RAM]='" + label_ramName.Text + "',[Storage]='" + label_storageName.Text
                        + "',[Power Supply]='" + label_psuName.Text + "',[Date]='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' where [Name]='" + textBox_buildName.Text + "'";
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved.");
                    return;
                }
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

        private void button_load_Click(object sender, EventArgs e)
        {
            LoadBuild FormA = new LoadBuild();
            FormA.returnLoader += ReloadForm;
            FormA.Show();
        }

        private void label_caseCoolerName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_caseCoolerName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadCaseCooler();
            }
        }


        private void label_cpuName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_cpuName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadProcessor();
            }
        }

        private void label_cpuCoolerName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_cpuCoolerName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadcpuCooler();
            }
        }

        private void label_psuName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_psuName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadPSU();
            }
        }


        private void label_motherboardName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_motherboardName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadMotherboard();
            }
        }


        private void label_storageName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_storageName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadStorage();
            }
        }

        private void label_ramName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_ramName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadMemory();
            }
        }


        private void label_gpuName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_gpuName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadGPU();
            }
        }


        private void label_caseName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_caseName.Text))
            {
                richTextBox_log.Text = Build.CompatibilityLog();
                LoadCase();
            }
        }


        private void button_nextComponent_Click(object sender, EventArgs e)
        {
            int i = tabControl_component.SelectedIndex;
            i++;
            if (i > 8)
                i = 0;
            tabControl_component.SelectedIndex = i;
            label_currentComponent.Text = tabControl_component.SelectedTab.Text;
            getCurrentModelName(i);
        }
        public void LoadMotherboard()
        {
            if (string.IsNullOrEmpty(label_motherboardName.Text))
            {
                label_motherboardBrand.Text = "";
                label_motherboardChipset.Text = "";
                label_motherboardSize.Text = "";
                label_motherboardSocket.Text = "";
                label_motherboardRAM.Text = "";
                label_motherboardStorage.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from Motherboard where Model = '" + label_motherboardName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_motherboardBrand.Text = Table.Rows[0][1].ToString();
            label_motherboardChipset.Text = Table.Rows[0][2].ToString();
            label_motherboardSize.Text = Table.Rows[0][3].ToString();
            label_motherboardSocket.Text=Table.Rows[0][4].ToString();
            label_motherboardRAM.Text="Slot quantity: "+Table.Rows[0][5].ToString()+"\nType: " + Table.Rows[0][6].ToString()+"\nSpeed: " + Table.Rows[0][7].ToString();
            label_motherboardStorage.Text = Table.Rows[0][8].ToString();
        }
        public void LoadProcessor()
        {
            if (label_cpuName.Text == "")
            {
                label_processorBrand.Text = "";
                label_processorPower.Text = "";
                label_processorSpeed.Text = "";
                label_processorSocket.Text = "";
                label_processorRAM.Text = "";
                label_processorInfo.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from Processor where Model = '" + label_cpuName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_processorBrand.Text = Table.Rows[0][1].ToString();
            label_processorPower.Text = Table.Rows[0][9].ToString();
            label_processorSpeed.Text = "Base Speed: "+Table.Rows[0][7].ToString()+"\nTurbo Speed: " + Table.Rows[0][8].ToString();
            label_processorSocket.Text = Table.Rows[0][4].ToString();
            label_processorRAM.Text = "Type: " + Table.Rows[0][5].ToString() + "\nSpeed: " + Table.Rows[0][6].ToString();
            label_processorInfo.Text = "Core: " + Table.Rows[0][3].ToString() + "\nThread: " + Table.Rows[0][4].ToString();
        }
        public void LoadStorage()
        {
            if (label_storageName.Text == "")
            {
                label_storageBrand.Text = "";
                label_storageInfo.Text = "";
                label_storageRPM.Text = "";
                label_storageInterface.Text = "";
                label_storageCache.Text = "";
                label_storageForm.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from Storage where Model = '" + label_storageName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_storageBrand.Text = Table.Rows[0][1].ToString();
            label_storageInfo.Text = "Capacity: " + Table.Rows[0][2].ToString() + "\nType: " + Table.Rows[0][3].ToString();
            label_storageRPM.Text = Table.Rows[0][4].ToString();
            label_storageInterface.Text = Table.Rows[0][5].ToString();
            label_storageCache.Text = Table.Rows[0][6].ToString();
            label_storageForm.Text = Table.Rows[0][7].ToString();
        }
        public void LoadMemory()
        {
            if (label_ramName.Text == "")
            {
                label_ramBrand.Text = "";
                label_ramType.Text = "";
                label_ramSpeed.Text = "";
                label_ramCapacity.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [RAM] where Model = '" + label_ramName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_ramBrand.Text = Table.Rows[0][1].ToString();
            label_ramType.Text = Table.Rows[0][4].ToString();
            label_ramSpeed.Text = Table.Rows[0][5].ToString();
            label_ramCapacity.Text = Table.Rows[0][2].ToString();
            
        }
        public void LoadPSU()
        {
            if (label_psuName.Text == "")
            {
                label_psuBrand.Text = "";
                label_psuPower.Text = "";
                label_psuEfficiency.Text = "";
                label_psuColor.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Power Supply] where Model = '" + label_psuName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_psuBrand.Text = Table.Rows[0][1].ToString();
            label_psuPower.Text = Table.Rows[0][2].ToString();
            label_psuEfficiency.Text = Table.Rows[0][3].ToString();
            label_psuColor.Text = Table.Rows[0][4].ToString();

        }
        public void LoadCase()
        {
            if (label_caseName.Text == "")
            {
                label_caseBrand.Text = "";
                label_casePanel.Text = "";
                label_caseSize.Text = "";
                label_caseCarbinet.Text = "";
                label_caseFormFactor.Text = "";
                label_caseColor.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Case] where Model = '" + label_caseName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_caseBrand.Text = Table.Rows[0][1].ToString();
            label_casePanel.Text = Table.Rows[0][2].ToString();
            label_caseSize.Text = "Max GPU Length: " + Table.Rows[0][6].ToString() + "\nCPU Cooler Heigh: " + Table.Rows[0][7].ToString() + "\nSupported PSU Size: " + Table.Rows[0][8].ToString();
            label_caseCarbinet.Text = Table.Rows[0][3].ToString();
            label_caseFormFactor.Text = Table.Rows[0][5].ToString();
            label_caseColor.Text = Table.Rows[0][4].ToString();

        }
        public void LoadGPU()
        {
            if (label_gpuName.Text == "")
            {
                label_gpuBrand.Text = "";
                label_gpuMemory.Text = "";
                label_gpuLength.Text = "";
                label_gpuInterface.Text = "";
                label_gpuPower.Text = "";
                label_gpuChipset.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Graphic Card] where Model = '" + label_gpuName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_gpuBrand.Text = Table.Rows[0][1].ToString();
            label_gpuMemory.Text = "VRAM: " + Table.Rows[0][2].ToString() + "\n Interface: " + Table.Rows[0][3].ToString();
            label_gpuLength.Text = Table.Rows[0][4].ToString();
            label_gpuInterface.Text = Table.Rows[0][5].ToString();
            label_gpuPower.Text = Table.Rows[0][7].ToString();
            label_gpuChipset.Text = Table.Rows[0][6].ToString();

        }
        public void LoadCaseCooler()
        {
            if (label_caseCoolerName.Text == "")
            {
                label_caseCoolerBrand.Text = "";
                label_caseCoolerNoise.Text = "";
                label_caseCoolerAir.Text = "";
                label_caseCoolerFan.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [Case Cooler] where Model = '" + label_caseCoolerName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_caseCoolerBrand.Text = Table.Rows[0][1].ToString();
            label_caseCoolerNoise.Text = Table.Rows[0][4].ToString();
            label_caseCoolerAir.Text = Table.Rows[0][3].ToString();
            label_caseCoolerFan.Text = Table.Rows[0][2].ToString();

        }
        public void LoadcpuCooler()
        {
            if (label_cpuCoolerName.Text == "")
            {
                label_cpuCoolerBrand.Text = "";
                label_cpuCoolerNoise.Text = "";
                label_cpuCoolerColor.Text = "";
                label_cpuCoolerFan.Text = "";
                return;
            }
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [CPU Cooler] where Model = '" + label_cpuCoolerName.Text + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            label_cpuCoolerBrand.Text = Table.Rows[0][1].ToString();
            label_cpuCoolerNoise.Text = Table.Rows[0][3].ToString();
            label_cpuCoolerColor.Text = Table.Rows[0][4].ToString();
            label_cpuCoolerFan.Text = Table.Rows[0][2].ToString();

        }
        private void button_previousComponent_Click(object sender, EventArgs e)
        {
            int i = tabControl_component.SelectedIndex;
            i--;
            if (i < 0)
                i = 8;
            tabControl_component.SelectedIndex = i;
            label_currentComponent.Text = tabControl_component.SelectedTab.Text;
            getCurrentModelName(i);
        }

        private void pictureBox_motherboard_Click(object sender, EventArgs e)
        {
            button_addMotherboard_Click(this, new EventArgs());
        }

        private void pictureBox_cpuCooler_Click(object sender, EventArgs e)
        {
            button_addCPUCooler_Click(this, new EventArgs());
        }

        private void pictureBox_cpu_Click(object sender, EventArgs e)
        {
            button_addCPU_Click(this, new EventArgs());
        }

        private void pictureBox_ram_Click(object sender, EventArgs e)
        {
            button_addRam_Click(this, new EventArgs());
        }

        private void pictureBox_psu_Click(object sender, EventArgs e)
        {
            button_addPSU_Click(this, new EventArgs());
        }

        private void pictureBox_gpu_Click(object sender, EventArgs e)
        {
            button_addGPU_Click(this, new EventArgs());
        }

        private void pictureBox_caseCooler_Click(object sender, EventArgs e)
        {
            button_addCaseCooler_Click(this, new EventArgs());
        }

        private void pictureBox_cpuCooler_Click_1(object sender, EventArgs e)
        {
            button_addCPUCooler_Click(this, new EventArgs());
        }

        private void pictureBox_storage_Click(object sender, EventArgs e)
        {
            button_addStorage_Click(this, new EventArgs());
        }

        private void tabPage_storage_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_component_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_currentComponent.Text = tabControl_component.SelectedTab.Text;
            getCurrentModelName(tabControl_component.SelectedIndex);
        }
    }
}

