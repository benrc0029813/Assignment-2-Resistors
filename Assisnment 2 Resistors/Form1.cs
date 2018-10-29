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
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
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
    }
}
