using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzerlik_Oran
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public float veri;
        public string yol;
        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.Series["Series1"].Points.AddXY(yol.ToString(),veri.ToString());
           
        }
    }
}
