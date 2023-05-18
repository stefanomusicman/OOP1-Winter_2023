using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LottoMaxForm obj = new LottoMaxForm();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lotto649Form obj = new Lotto649Form();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoneyExchangeForm obj = new MoneyExchangeForm();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TempConversionForm obj = new TempConversionForm();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalculatorForm obj = new CalculatorForm();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IPValidatorForm obj = new IPValidatorForm();
            obj.Show();
        }
    }
}
