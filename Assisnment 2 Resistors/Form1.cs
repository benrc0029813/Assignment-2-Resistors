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
            comboBox1.SelectedIndex = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double D3 = Convert.ToDouble(textBox3.Text);
                double D4 = Convert.ToDouble(textBox4.Text);
                double TotalResistance = 1 / (1 / D3 + 1 / D4);
                label6.Text = TotalResistance.ToString();
            }
            catch
            {
                label6.Text = "Error unable to calculate.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.SelectedIndex == 0)
            {
                HideAll();
                textBox1.Show();
                textBox2.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                button1.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                HideAll();
                textBox3.Show();
                textBox4.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                button2.Show();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                HideAll();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                button3.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                HideAll();
                textBox8.Show();
                textBox9.Show();
                textBox10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                button4.Show();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                HideAll();
                textBox11.Show();
                textBox12.Show();
                textBox13.Show();
                textBox14.Show();
                label15.Show();
                label16.Show();
                label17.Show();
                label18.Show();
                label19.Show();
                button5.Show();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                HideAll();
                textBox15.Show();
                textBox16.Show();
                textBox17.Show();
                textBox18.Show();
                label20.Show();
                label21.Show();
                label22.Show();
                label23.Show();
                label24.Show();
                button6.Show();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                HideAll();
                textBox19.Show();
                textBox20.Show();
                textBox21.Show();
                textBox22.Show();
                textBox23.Show();
                label25.Show();
                label26.Show();
                label27.Show();
                label28.Show();
                label29.Show();
                label30.Show();
                button7.Show();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                HideAll();
                textBox24.Show();
                textBox25.Show();
                textBox26.Show();
                textBox27.Show();
                textBox28.Show();
                label31.Show();
                label32.Show();
                label33.Show();
                label34.Show();
                label35.Show();
                label36.Show();
                button8.Show();
            }
        }

        private void HideAll()
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            textBox11.Hide();
            textBox12.Hide();
            textBox13.Hide();
            textBox14.Hide();
            textBox15.Hide();
            textBox16.Hide();
            textBox17.Hide();
            textBox18.Hide();
            textBox19.Hide();
            textBox20.Hide();
            textBox21.Hide();
            textBox22.Hide();
            textBox23.Hide();
            textBox24.Hide();
            textBox25.Hide();
            textBox26.Hide();
            textBox27.Hide();
            textBox28.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            label18.Hide();
            label19.Hide();
            label20.Hide();
            label21.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            label25.Hide();
            label26.Hide();
            label27.Hide();
            label28.Hide();
            label29.Hide();
            label30.Hide();
            label31.Hide();
            label32.Hide();
            label33.Hide();
            label34.Hide();
            label35.Hide();
            label36.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double D5 = Convert.ToDouble(textBox5.Text);
                double D6 = Convert.ToDouble(textBox6.Text);
                double D7 = Convert.ToDouble(textBox7.Text);
                double TotalResistance = D5 + D6 + D7;
                label10.Text = TotalResistance.ToString();
            }
            catch
            {
                label10.Text = "Error unable to calculate.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double D8 = Convert.ToDouble(textBox8.Text);
                double D9 = Convert.ToDouble(textBox9.Text);
                double D10 = Convert.ToDouble(textBox10.Text);
                double TotalResistance = 1 / (1 / D8 + 1 / D9 + 1 / D10);
                label14.Text = TotalResistance.ToString();
            }
            catch
            {
                label14.Text = "Error unable to calculate.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double D11 = Convert.ToDouble(textBox11.Text);
                double D12 = Convert.ToDouble(textBox12.Text);
                double D13 = Convert.ToDouble(textBox13.Text);
                double D14 = Convert.ToDouble(textBox14.Text);
                double TotalResistance = D11 + D12 + D13 + D14;
                label19.Text = TotalResistance.ToString();
            }
            catch
            {
                label19.Text = "Error unable to calculate.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double D15 = Convert.ToDouble(textBox15.Text);
                double D16 = Convert.ToDouble(textBox16.Text);
                double D17 = Convert.ToDouble(textBox17.Text);
                double D18 = Convert.ToDouble(textBox18.Text);
                double TotalResistance = 1 / (1 / D15 + 1 / D16 + 1 / D17 + 1 / D18);
                label24.Text = TotalResistance.ToString();
            }
            catch
            {
                label24.Text = "Error unable to calculate.";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double D19 = Convert.ToDouble(textBox19.Text);
                double D20 = Convert.ToDouble(textBox20.Text);
                double D21 = Convert.ToDouble(textBox21.Text);
                double D22 = Convert.ToDouble(textBox22.Text);
                double D23 = Convert.ToDouble(textBox23.Text);
                double TotalResistance = D19 + D20 + D21 + D22 + D23;
                label30.Text = TotalResistance.ToString();
            }
            catch
            {
                label30.Text = "Error unable to calculate.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double D24 = Convert.ToDouble(textBox24.Text);
                double D25 = Convert.ToDouble(textBox25.Text);
                double D26 = Convert.ToDouble(textBox26.Text);
                double D27 = Convert.ToDouble(textBox27.Text);
                double D28 = Convert.ToDouble(textBox28.Text);
                double TotalResistance = 1 / (1 / D24 + 1 / D25 + 1 / D26 + 1 / D27 + 1 / D28);
                label36.Text = TotalResistance.ToString();
            }
            catch
            {
                label36.Text = "Error unable to calculate.";
            }
        }
    }
}
