using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace PC_Building
{
    public partial class PriceCalculator : Form
    {
        Building_Simulator simulator;
        double TotalPrice;
        public PriceCalculator(Building_Simulator Build)
        {
            InitializeComponent();
            simulator = Build;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            TotalPrice = 0;
            AddProduct();
        }
        private void AddProduct()
        {
            int i = 1;
            if (!string.IsNullOrEmpty(simulator.motherboard.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.motherboard.Model, "Motherboard", simulator.motherboard.Price);
                i++;
                TotalPrice = TotalPrice + simulator.motherboard.Price;
            }
            if (!string.IsNullOrEmpty(simulator.processor.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.processor.Model, "Processor", simulator.processor.Price);
                i++;
                TotalPrice = TotalPrice+ simulator.processor.Price;
            }
            if (!string.IsNullOrEmpty(simulator.ram.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.ram.Model + " " + simulator.ram.Quantity, "Ram", simulator.ram.Price);
                i++;
                TotalPrice = TotalPrice + simulator.ram.Price;
            }
            if (!string.IsNullOrEmpty(simulator.graphicCard.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.graphicCard.Model, "VGA", simulator.graphicCard.Price);
                i++;
                TotalPrice = TotalPrice + simulator.graphicCard.Price;
            }
            if (!string.IsNullOrEmpty(simulator.cpuCase.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.cpuCase.Model, "Case", simulator.cpuCase.Price);
                i++;
                TotalPrice = TotalPrice + simulator.cpuCase.Price;
            }
            if (!string.IsNullOrEmpty(simulator.cpuCooler.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.cpuCooler.Model, "CPU Cooler", simulator.cpuCooler.Price);
                i++;
                TotalPrice = TotalPrice + simulator.cpuCooler.Price;
            }
            if (!string.IsNullOrEmpty(simulator.caseCooler.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.caseCooler.Model, "Case Cooler", simulator.caseCooler.Price);
                i++;
                TotalPrice = TotalPrice + simulator.caseCooler.Price;
            }
            if (!string.IsNullOrEmpty(simulator.storage.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.storage.Model, "Storage", simulator.storage.Price);
                i++;
                TotalPrice = TotalPrice + simulator.storage.Price;
            }
            if (!string.IsNullOrEmpty(simulator.powerSupply.Model))
            {
                this.dataGridView1.Rows.Add(i, simulator.powerSupply.Model, "Power Supply", simulator.powerSupply.Price);
                i++;
                TotalPrice = TotalPrice + simulator.powerSupply.Price;
            }
            TotalPrice = Math.Round(TotalPrice, 2,MidpointRounding.AwayFromZero);
            label_totalPrice.Text = TotalPrice.ToString() + "$";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
