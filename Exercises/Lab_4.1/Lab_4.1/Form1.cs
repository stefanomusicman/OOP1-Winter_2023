using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(input1.Text);
                double num2 = Convert.ToDouble(input2.Text);
                double total = num1 + num2;
                addResult.Text = total.ToString();
            } 
            catch(FormatException)
            {
                MessageBox.Show("Invalid input enter two numbers please");
            }
            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(input1.Text);
                double num2 = Convert.ToDouble(input2.Text);
                double total = num1 - num2;
                subResult.Text = total.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input enter two numbers please");
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(input1.Text);
                double num2 = Convert.ToDouble(input2.Text);
                double total = num1 * num2;
                multResult.Text = total.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input enter two numbers please");
            }
        }

        private void divResult_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);
            double total = num1 / num2;
            divResult.Text = total.ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(input1.Text);
                double num2 = Convert.ToDouble(input2.Text);
                double total = num1 / num2;
                divResult.Text = total.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input enter two numbers please");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
