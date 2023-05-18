using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_form_practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm obj = new TestForm();
            obj.Show(); // this will allow you to open up as many forms as you like
            //obj.ShowDialog(); // -- this will allow you to open only one form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringHandling obj = new StringHandling();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
