using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Validator validator = new Validator();

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            if(validator.ValidateSession(comboBox_session.Text) && validator.ValidateYear(comboBox_year.Text))
            {
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Input\nYears must be between 2023 and 2025\nSession must be either Fall, Winter or Summer", "Invalid Input");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        // this is for when the form initially loads up
        private void btn_lasalle_Load(object sender, EventArgs e)
        {
            List<String> sessions = new List<String>{ "Fall", "Winter", "Summer" };
            List<Int16> years = new List<Int16> { 2023, 2024, 2025 };

            comboBox_session.DataSource = sessions;
            comboBox_year.DataSource = years;
        }
    }
}
