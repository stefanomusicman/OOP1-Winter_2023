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
    public partial class Lotto649Form : Form
    {
        List<int> lottoNums = new List<int>();
        string txtPath = @"../../textFiles/LottoNbrs.txt";
        public Lotto649Form()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            lottoNums.Clear();
            resultsBox.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 49);

            for (Int16 i = 1; i < 8; i++)
            {
                while (lottoNums.Contains(randomNumber) == true)
                {
                    randomNumber = random.Next(1, 50);
                }
                lottoNums.Add(randomNumber);
            }

            foreach (int num in lottoNums)
            {
                resultsBox.Text = $"{resultsBox.Text}{num}\t\t";
            }

            FileStream fs = new FileStream(txtPath, FileMode.Append, FileAccess.Write);
            StreamWriter updatedNumbersList = new StreamWriter(fs);
            updatedNumbersList.Write($"649,  {DateTime.Now},  ");
            for (Int16 i = 0; i < lottoNums.Count; i++)
            {
                if (lottoNums[i] == lottoNums.Last())
                {
                    updatedNumbersList.WriteLine($"  Bonus {lottoNums[i]}");
                }
                else
                {
                    updatedNumbersList.Write($"{lottoNums[i]}, ");
                }
            }
            updatedNumbersList.Close();
            fs.Close();
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtPath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader results = new StreamReader(fs);
            List<String> resultsList = new List<String>();
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                this.Close();
            }
        }
    }
}
