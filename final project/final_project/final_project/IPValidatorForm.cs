using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

 Written by Stefano Proietti
 Student ID: 2012831
 
*/

namespace final_project
{
    public partial class IPValidatorForm : Form
    {
        public IPValidatorForm()
        {
            InitializeComponent();
        }
        DateTime timeOfOpening;
        DateTime currentDate = DateTime.Today;
        DateTime endTime;
        string binaryPath = @"../../binaryFiles/ip4.dat";

        private void IPValidatorForm_Load(object sender, EventArgs e)
        {
            timeOfOpening = DateTime.Now;
            label1.Text = $"Today : {currentDate.ToLongDateString()}";
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (regex.IsMatch(textBox1.Text))
            {
                FileStream fs = new FileStream(binaryPath, FileMode.Append, FileAccess.Write);
                BinaryWriter binaryOut = new BinaryWriter(fs);
                binaryOut.Write(textBox1.Text.Trim());
                binaryOut.Close();
                MessageBox.Show($"{textBox1.Text}\nThis IP is valid","Valid IP");
            } 
            else
            {
                MessageBox.Show($"{textBox1.Text}\nThe IP must have 4 bytes\nInteger number between 0 and 255\n" +
                    $"Seperated by a dot (255.255.255.255)","Error");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application IP4-Validator?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                endTime = DateTime.Now;

                TimeSpan timeDiff = endTime - timeOfOpening;
                int seconds = (int)timeDiff.TotalSeconds;
                int minutes = (int)timeDiff.TotalMinutes;
                string message = $"Time on form: {seconds} seconds ({minutes} minutes)";
                MessageBox.Show(message);
                this.Close();
            }
        }
    }
}
