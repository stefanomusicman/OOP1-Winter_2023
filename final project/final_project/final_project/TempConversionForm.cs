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
    public partial class TempConversionForm : Form
    {
        public TempConversionForm()
        {
            InitializeComponent();
        }

        TempConversion obj = new TempConversion();
        char startingUnit = 'C';
        char convertedUnit = 'F';
        Double convertedAmount;
        string txtPath = @"../../textFiles/tempConversions.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            obj.startingUnit = startingUnit;
            obj.label = messageLabel;
            try
            {
                obj.startingAmount = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input, please enter a number.");
            }
            convertedAmount = obj.DetermineConversion();
            textBox2.Text = convertedAmount.ToString();
            obj.DetermineMessage();

            FileStream fs = new FileStream(txtPath, FileMode.Append, FileAccess.Write);
            StreamWriter conversionList = new StreamWriter(fs);
            conversionList.WriteLine($"{obj.startingAmount} {startingUnit} = {convertedAmount} {convertedUnit},   " +
                $"{DateTime.Now}   {messageLabel.Text}");
            conversionList.Close();
            fs.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "C";
            label3.Text = "F";
            startingUnit = 'C';
            convertedUnit = 'F';
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "F";
            label3.Text = "C";
            startingUnit = 'F';
            convertedUnit = 'C';
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtPath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader results = new StreamReader(fs);
            String allMessages = "";

            while (results.EndOfStream == false)
            {
                allMessages = allMessages + results.ReadLine() + '\n';
            }
            results.Close();
            fs.Close();

            MessageBox.Show(allMessages);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application Temperature Conversion?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                this.Close();
            }
        }
    }
}
