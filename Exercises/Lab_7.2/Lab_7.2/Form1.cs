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

namespace Lab_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String txtPath = "C:\\Users\\stefp\\Desktop\\Lasalle Classes\\Winter 2023\\Object Oriented Programming Concepts\\Exercises\\Lab_7.2\\Lab_7.2\\NamesText.txt";
        String pathBinary = "C:\\Users\\stefp\\Desktop\\Lasalle Classes\\Winter 2023\\Object Oriented Programming Concepts\\Exercises\\Lab_7.2\\Lab_7.2\\NamesBin.dat";
        FileStream fs = null;

        private void button1_Click(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@"^[a-zA-z]+$");
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && myRegex.IsMatch(textBox1.Text) && myRegex.IsMatch(textBox2.Text))
            {
                StreamWriter namesList = new StreamWriter(txtPath, true);
                namesList.WriteLine($"First Name: {textBox1.Text}  Last Name: {textBox2.Text}");
                namesList.Close();
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("LName: is a required field.");
            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("FName: is a required field.");
            }
            else
            {
                MessageBox.Show("Please enter valid inputs.");
            }
        }

        private void readTxtBtn_Click(object sender, EventArgs e)
        {
            StreamReader namesList = new StreamReader(txtPath);
            String messages = "";
            while(namesList.EndOfStream == false)
            {
                messages += namesList.ReadLine() + "\n";
            }
            namesList.Close();
            MessageBox.Show(messages);
        }

        private void writeBinBtn_Click(object sender, EventArgs e)
        {
            fs = new FileStream(pathBinary, FileMode.Append, FileAccess.Write);
            BinaryWriter binaryOut = new BinaryWriter(fs);
            binaryOut.Write(textBox1.Text);
            binaryOut.Write(textBox2.Text);
            binaryOut.Close();        
        }

        private void readBinBtn_Click(object sender, EventArgs e)
        {
            fs = new FileStream(pathBinary, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader binaryIn = new BinaryReader(fs);
            String textToPrint = "FName\t LName\n";
            String LName, FName;

            while(binaryIn.PeekChar() != -1)
            {
                FName = binaryIn.ReadString();
                LName = binaryIn.ReadString();
                textToPrint += FName + ", \t" + LName + "\n";
            }

            MessageBox.Show(textToPrint);
            binaryIn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
