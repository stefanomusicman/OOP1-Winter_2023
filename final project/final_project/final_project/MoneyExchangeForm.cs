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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

/*

 Written by Stefano Proietti
 Student ID: 2012831
 
*/

namespace final_project
{
    public partial class MoneyExchangeForm : Form
    {
        MoneyExchange obj = new MoneyExchange();
        string txtPath = @"../../textFiles/moneyExchange.txt";
        private DateTime startTime;
        private DateTime endTime;

        public MoneyExchangeForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double convertedAmount = 0;
            obj.textBox1 = textBox1;
            obj.textBox2 = textBox2;
            // List of radio buttons in first box
            List<System.Windows.Forms.RadioButton> radioButtons1 = new List<System.Windows.Forms.RadioButton>()
            {
                fromCadBtn,
                fromEurBtn,
                fromUsdBtn,
                fromGdpBtn,
                fromDongBtn,
            };

            // List of radio buttons in second box
            List<System.Windows.Forms.RadioButton> radioButtons2 = new List<System.Windows.Forms.RadioButton>()
            {
                toCadBtn,
                toEurBtn,
                toUsdBtn,
                toGdpBtn,
                toDongBtn,
            };

            // loop to determine what the starting currency is
            foreach(var button in radioButtons1)
            {
                if(button.Checked)
                {
                    obj.startingCurrency = button.Text;
                }
            }

            // loop to determine what the new currency will be
            foreach (var button in radioButtons2)
            {
                if (button.Checked)
                {
                    obj.newCurrency = button.Text;
                }
            }

            try
            {
                obj.startingAmount = Convert.ToDouble(textBox1.Text);
            } 
            catch
            {
                MessageBox.Show("Invalid input, please enter a number.");
            }

            convertedAmount = obj.convert();

            FileStream fs = new FileStream(txtPath, FileMode.Append, FileAccess.Write);
            StreamWriter updatedConversionsList = new StreamWriter(fs);
            updatedConversionsList.WriteLine($"{obj.startingAmount} {obj.startingCurrency} = {convertedAmount} {obj.newCurrency},   " +
                $"{DateTime.Now}");
            updatedConversionsList.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to quit the application Money Exchange?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                endTime = DateTime.Now;

                TimeSpan timeDiff = endTime - startTime;
                int seconds = (int)timeDiff.TotalSeconds;
                int minutes = (int)timeDiff.TotalMinutes;
                string message = $"Time on form: {seconds} seconds ({minutes} minutes)";
                MessageBox.Show(message);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtPath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader results = new StreamReader(fs);
            List<String> resultsList = new List<string>();
            String allMessages = "";

            while (results.EndOfStream == false)
            {
                resultsList.Add(results.ReadLine());
            }

            foreach (String result in resultsList)
            {
                allMessages = allMessages + result + "\n";
            }
            results.Close();
            fs.Close();

            MessageBox.Show(allMessages);
        }

        private void MoneyExchangeForm_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
        }
    }
}
