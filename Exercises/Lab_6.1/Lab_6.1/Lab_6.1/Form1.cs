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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkEmailBtn_Click(object sender, EventArgs e)
        {
            String email = inputBox.Text;
            System.Text.RegularExpressions.Regex myRegex = new Regex(@"^.{1,10}@[a-z]{3,10}.com$");
            bool isvalid = myRegex.IsMatch(email);

            if(isvalid)
            {
                MessageBox.Show("Email is Valid!");
            } else
            {
                MessageBox.Show("Email is invalid.");
            }
        }

        private void checkPostalBtn_Click(object sender, EventArgs e)
        {
            String postalCode = Convert.ToString(inputBox.Text).Trim();
            System.Text.RegularExpressions.Regex myRegex = new Regex(@"^[A-Z]\d[A-Z](\s)*(-)*\d[A-Z]\d$");
            bool isvalid = myRegex.IsMatch(postalCode);

            if (isvalid)
            {
                MessageBox.Show("Postal Code is Valid!");
            }
            else
            {
                MessageBox.Show("Postal Code is invalid.");
            }
        }

        private void removeSpaceBtn_Click(object sender, EventArgs e)
        {
            String input = Convert.ToString(inputBox.Text);
            System.Text.RegularExpressions.Regex myRegex = new Regex(@"\s+");
            String newInput = myRegex.Replace(input, "");
            inputBox.Text = newInput;
        }

        private void deleteLettersBtn_Click(object sender, EventArgs e)
        {
            String input = Convert.ToString(inputBox.Text);
            System.Text.RegularExpressions.Regex myRegex = new Regex(@"[a-d]+");
            String newInput = myRegex.Replace(input, "");
            MessageBox.Show($"Here is your input after trimmed: {newInput}");
        }

        private void createArrayBtn_Click(object sender, EventArgs e)
        {
            string tempo = "";
            String input = Convert.ToString(inputBox.Text);
            String[] items = Regex.Split(input, @"\s");
            for(Int16 i = 0; i < items.Length; i++)
            {
                if (items[i].Length > 0) { tempo += items[i] + "\n"; }
            }
            MessageBox.Show(tempo);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
