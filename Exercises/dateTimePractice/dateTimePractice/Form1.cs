using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime initialDate = new DateTime();
            DateTime startDate =  new DateTime(2023, 01, 30); // 1/30/2023 12:00 AM
            DateTime startDateAndTime = new DateTime(2023, 1, 30, 14, 15, 0); // 1/30/2023 2:15 PM

            MessageBox.Show($"startDate = {startDate}\nstartDateAndTime = {startDateAndTime}\n" +
                $"initialDate = {initialDate}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse("01/30/2023"); // 1/30/2023 12:00 AM
            DateTime startDateAndTime = DateTime.Parse("Jan 30, 2023 2:15 PM"); // 1/30/2023 2:15 PM
            DateTime invoiceDate = DateTime.Parse(textBox1.Text);

            MessageBox.Show($"startDate = {startDate}\nstartDateAndTime = {startDateAndTime}\n" +
                $"initialDate = {invoiceDate}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime invoiceDate;
            DateTime.TryParse(textBox1.Text, out invoiceDate);

            MessageBox.Show($"invoiceDate = {invoiceDate}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            MessageBox.Show($"invoiceDate = {currentDateTime}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            MessageBox.Show($"invoiceDate = {currentDate}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string longDate = currentDateTime.ToLongDateString();
            string shortDate = currentDateTime.ToShortDateString();
            string longTime = currentDateTime.ToLongTimeString();
            string shortTime = currentDateTime.ToShortTimeString();
            MessageBox.Show($"longDate = {longDate}\nshortDate = {shortDate}\n" +
                $"longTime = {longTime}\nshortTime = {shortTime}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            DayOfWeek dayOfWeek = currentDateTime.DayOfWeek;
            string message = "";
            if (dayOfWeek == DayOfWeek.Saturday ||
             dayOfWeek == DayOfWeek.Sunday)
            {
                message = "Weekend";
            }
            else
            {
                message = "Weekday";
                if(dayOfWeek == DayOfWeek.Friday)
                {
                    message += "\nHaving some C# programming!";
                }
            }
            MessageBox.Show(message);
        }
    }
}
