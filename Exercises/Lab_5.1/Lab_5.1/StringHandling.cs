using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5._1
{
    public partial class StringHandling : Form
    {
        public StringHandling()
        {
            InitializeComponent();
        }

        static String formatString(String word)
        {
            String firstLetter = word.Substring(0,1).ToUpper();
            string otherLetters = word.Substring(1).ToLower();
            return firstLetter + otherLetters;
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text.Trim();
            String[] result = name.Split(' ');

            switch(result.Length)
            {
                case 2:
                    MessageBox.Show($"First Name: {formatString(result[0])}\n\nLast Name: {formatString(result[1])}");
                    break;
                case 3:
                    MessageBox.Show($"First Name: {formatString(result[0])}\n\nMiddle Name: {formatString(result[1])}\nLast Name: {formatString(result[2])}");
                    break;
                default:
                    MessageBox.Show("Please enter your first name, middle name (optional) and last name");
                    break;
            }
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("(?:[^0-9]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            String cleanedString = r.Replace(phoneTextBox.Text, "");
            String standardFormat = cleanedString;
            standardFormat = standardFormat.Insert(3, "-");
            standardFormat = standardFormat.Insert(7, "-");

            if (cleanedString.Length == 10)
            {
                MessageBox.Show($"Entered: {phoneTextBox.Text}\n\nDigits Only: {cleanedString}\n\n" +
                    $"Standard Format: {standardFormat}");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
