using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/* 

Mid-Term Windows Forms Application
Stefano Proietti
Student Number: 2012831
Date: March 3, 2023
 
*/

namespace MidTermWindowsForm
{
    public partial class frm_ConvertLength : Form
    {
        public frm_ConvertLength()
        {
            InitializeComponent();
        }

        private void frm_ConvertLength_Load(object sender, EventArgs e)
        {
            txtBox3.Text = "0";
            txtBox4.Text = "0";
            txtBox4.ReadOnly = true;
            txtBox5.Text = "0";
            txtBox5.ReadOnly = true;
            txtBox6.Text = "0";
            txtBox7.Text = "0";
            txtBox7.ReadOnly = true;
            txtBox8.Text = "0";
            txtBox8.ReadOnly = true;
        }

        private void btnMtoYd_Click(object sender, EventArgs e)
        {
            ConvertLength conversion = new ConvertLength();

            try
            {
                conversion.Num = Convert.ToDouble(txtBox3.Text);
                txtBox3.ReadOnly = true;
                txtBox6.Focus();
            }
            catch
            {
                MessageBox.Show("Input String was not in correct format");
            }
            txtBox4.Text = conversion.MetreToCm().ToString();
            txtBox5.Text = conversion.MetreToYards().ToString();
        }

        private void btnKmtoMile_Click(object sender, EventArgs e)
        {
            ConvertLength conversion = new ConvertLength();

            try
            {
                conversion.Num = Convert.ToDouble(txtBox6.Text);
                txtBox6.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Input String was not in correct format");
            }
            txtBox7.Text = conversion.KmToMetres().ToString();
            txtBox8.Text = conversion.KmToMiles().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBox3.Text = "0";
            txtBox3.ReadOnly = false;
            txtBox4.Text = "0";
            txtBox4.ReadOnly = true;
            txtBox5.Text = "0";
            txtBox5.ReadOnly = true;
            txtBox6.Text = "0";
            txtBox6.ReadOnly = false;
            txtBox7.Text = "0";
            txtBox7.ReadOnly = true;
            txtBox8.Text = "0";
            txtBox8.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                txtBox3.Text = "0";
                txtBox3.ReadOnly = false;
                txtBox4.Text = "0";
                txtBox4.ReadOnly = true;
                txtBox5.Text = "0";
                txtBox5.ReadOnly = true;
                txtBox6.Text = "0";
                txtBox6.ReadOnly = false;
                txtBox7.Text = "0";
                txtBox7.ReadOnly = true;
                txtBox8.Text = "0";
                txtBox8.ReadOnly = true;
            }
        }
    }
}
