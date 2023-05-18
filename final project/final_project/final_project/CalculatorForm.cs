using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

 Written by Stefano Proietti
 Student ID: 2012831
 
*/

namespace final_project
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator();

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        // this is an event that fires for all buttons numbered 0 - 9
        private void button9_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                textBox1.Text += clickedButton.Text;
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text += buttonDecimal.Text;
            buttonDecimal.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            calc.Add(textBox1.Text);
            textBox1.Clear();
            label1.Text = calc.labelValue;
            buttonDecimal.Enabled = true;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            calc.Subtract(textBox1.Text);
            textBox1.Clear();
            label1.Text = calc.labelValue;
            buttonDecimal.Enabled = true;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            calc.Multiply(textBox1.Text);
            textBox1.Clear();
            label1.Text = calc.labelValue;
            buttonDecimal.Enabled = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            calc.Division(textBox1.Text);
            textBox1.Clear();
            label1.Text = calc.labelValue;
            buttonDecimal.Enabled = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            String result = calc.Equal(textBox1.Text);
            textBox1.Text = result;
            label1.Text = calc.labelValue;
            buttonDecimal.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            calc.isPerformed = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                this.Close();
            }
        }
    }
}
