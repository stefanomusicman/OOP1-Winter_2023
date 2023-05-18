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

namespace FinalPrepForm
{
    public partial class Form1 : Form
    {
        User obj = new User();

        public Form1()
        {
            InitializeComponent();
        }

        string path = @"../../info.txt";
        string xmlFromTxtPath = @"../../xmlFromTxt.xml";

        private void btn_name_Click(object sender, EventArgs e)
        {
            if(obj.ValidateName(txt_name.Text) == true)
            {
                obj.Name = txt_name.Text;
                btn_name.Enabled = false;
                txt_city.Focus();
                btn_city.Enabled = true;
                MessageBox.Show($"{txt_name.Text}\nIs a valid Name");
            } 
            else
            {
                MessageBox.Show("Enter (1) a valid name!\n " +
                    "2 up to 50 characters.");
            }
        }

        private void btn_city_Click(object sender, EventArgs e)
        {
            if (obj.ValidateCity(txt_city.Text) == true)
            {
                obj.City = txt_city.Text;
                btn_city.Enabled = false;
                txt_age.Focus();
                btn_age.Enabled = true;
                MessageBox.Show($"{txt_city.Text}\nIs a valid City");
            }
            else
            {
                MessageBox.Show("Enter (2) a valid city!\n " +
                    "Montreal, Ottawa or Toronto.");
            }
        }

        private void btn_age_Click(object sender, EventArgs e)
        {
            if (obj.ValidateAge(txt_age.Text) == true)
            {
                obj.Age = Convert.ToInt16(txt_age.Text);
                btn_age.Enabled = false;
                btn_appendToTxt.Focus();
                MessageBox.Show($"{txt_age.Text}\nIs a valid Age");
            }
            else
            {
                MessageBox.Show("Enter (3) a valid number!\n " +
                    "Should be between 18 and 65.");
            }
        }

        private void btn_appendToTxt_Click(object sender, EventArgs e)
        {
            obj.AppendToTxt(path);
            MessageBox.Show("The user was appended to the text file", "User Registered");
        }

        private void btn_readTxt_appendXml_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ReadTxtCreateXML(path, xmlFromTxtPath));
        }

        private void btn_readXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.ReadXml(xmlFromTxtPath), "Reading");
        }

        private void btn_deleteTxt_Click(object sender, EventArgs e)
        {
            File.Delete(path);
            MessageBox.Show("The file was deleted.");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
