using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assisnment_2_Resistors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double D1 = Convert.ToDouble(textBox1.Text);
                double D2 = Convert.ToDouble(textBox2.Text);
                double TotalResistance = D1 + D2;
                label3.Text = TotalResistance.ToString();
            }
            catch
            {
                label3.Text = "Error unable to calculate.";
            }
        }
    }
}
