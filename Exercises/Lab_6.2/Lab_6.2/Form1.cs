using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime futureDate = DateTime.Parse(textBox1.Text);

            MessageBox.Show($"Current Date:  {DateTime.Today.ToLongDateString()}\n\nFuture Date:  {futureDate.ToLongDateString()}\n\n" +
                $"Due Days: {(futureDate - DateTime.Today).TotalDays}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime birthDate = DateTime.Parse(textBox2.Text);
            int age;

            if(birthDate.Month == DateTime.Today.Month && birthDate.Day <= DateTime.Today.Day)
            {
                age = DateTime.Today.Year - birthDate.Year;
            } else
            {
                age = DateTime.Today.Year - birthDate.Year - 1;
            }

            MessageBox.Show($"Current Date:  {DateTime.Today.ToLongDateString()}\n\nBirth Date:  {birthDate.ToLongDateString()}\n\n" +
                $"Age: {age}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
