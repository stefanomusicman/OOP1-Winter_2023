using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMTPrep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ConvertArea conversion = new ConvertArea();
            try
            {
                conversion.Num = Convert.ToDouble(textBox1.Text);
                textBox1.ReadOnly = true;
                textBox3.Focus();
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
            textBox2.Text = conversion.CmToInches().ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ConvertArea conversion = new ConvertArea();
            try
            {
                conversion.Num = Convert.ToDouble(textBox3.Text);
                textBox3.ReadOnly = true;
                textBox5.Focus();
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
            textBox4.Text = conversion.MetresToYards().ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ConvertArea conversion = new ConvertArea();
            try
            {
                conversion.Num = Convert.ToDouble(textBox5.Text);
                textBox5.ReadOnly = true;
                textBox7.Focus();
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
            textBox6.Text = conversion.HecToAcres().ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConvertArea conversion = new ConvertArea();
            try
            {
                conversion.Num = Convert.ToDouble(textBox7.Text);
                textBox7.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
            textBox8.Text = conversion.KmToMiles().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.ReadOnly = false;            
            textBox3.Text = "0";
            textBox3.ReadOnly = false;
            textBox5.Text = "0";
            textBox5.ReadOnly = false;
            textBox7.Text = "0";
            textBox7.ReadOnly = false;

            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox8.Clear();
        }
    }
}
