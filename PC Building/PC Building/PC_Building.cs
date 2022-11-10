using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Building
{
    public partial class PC_Building : Form
    {
        Building_Simulator Build = new Building_Simulator();
        public PC_Building()
        {
            InitializeComponent();
        }
    }
}
