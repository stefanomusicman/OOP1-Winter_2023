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

namespace Lab_7._1
{
    public partial class Form1 : Form
    {
        String txtPath = "C:\\Users\\stefp\\Desktop\\Lasalle Classes\\Winter 2023\\Object Oriented Programming Concepts\\Exercises\\Lab_7.1\\Lab_7.1\\nameTextFile.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            StreamWriter nameList = new StreamWriter(txtPath, true);
            if(regex.IsMatch(textBox1.Text) && regex.IsMatch(textBox2.Text))
            {
                nameList.WriteLine($"{textBox1.Text}  ;  {textBox2.Text}  ;  {DateTime.Today}");
                MessageBox.Show("Names were successfully written to file!", "Confirmation");
            } else
            {
                MessageBox.Show("Please enter valid names in the textboxes.");
            }
            nameList.Close();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            StreamReader results = new StreamReader(txtPath);
            String info = "";
            while(results.EndOfStream == false)
            {
                info = results.ReadLine() + "\n";
            }
            results.Close();
            MessageBox.Show(info);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
