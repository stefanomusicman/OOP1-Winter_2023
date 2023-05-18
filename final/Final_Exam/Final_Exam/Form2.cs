using Final_Exam;
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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Exam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String txtPath = @"../../W2023/Final.txt";
        String xmlPath = @"../../W2023/Final.xml";

        Validator validator = new Validator();
        Grades grades = new Grades();

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if(validator.ValidateGrade(ftx_midterm.Text) == false)
            {
                MessageBox.Show("Invalid input, mid term number must be between 0 and 100.");
            } 
            else if(validator.ValidateGrade(ftx_project.Text) == false)
            {
                MessageBox.Show("Invalid input, project number must be between 0 and 100.");
            }
            else if (validator.ValidateGrade(ftx_final.Text) == false)
            {
                MessageBox.Show("Invalid input, final number must be between 0 and 100.");
            } 
            else
            {
                ftx_midterm_result.Text = Convert.ToString(grades.CalcluateMidTermPercentage(Convert.ToInt16(ftx_midterm.Text)));
                ftx_project_result.Text = Convert.ToString(grades.CalcluateProjectPercentage(Convert.ToInt16(ftx_project.Text)));
                ftx_final_result.Text = Convert.ToString(grades.CalcluateFinalPercentage(Convert.ToInt16(ftx_final.Text)));
                ftx_numGrade.Text = Convert.ToString(grades.CalculateTotal());
                ftx_letterGrade.Text = Convert.ToString(grades.CalculateLetterGrade());
            }
        }

        private void btn_writeTxt_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtPath, FileMode.Append, FileAccess.Write);
            StreamWriter txtWriter = new StreamWriter(fs);
            txtWriter.WriteLine(ftx_midterm.Text.Trim() + " " + ftx_midterm_result.Text.Trim() + " " +
                ftx_project.Text.Trim() + " " + ftx_project_result.Text.Trim() + " " + 
                ftx_final.Text.Trim() + " " + ftx_final_result.Text.Trim() + " " +
                ftx_numGrade.Text.Trim() + " " + ftx_letterGrade.Text.Trim() + " " +"|");
            txtWriter.Close();
            fs.Close();
            MessageBox.Show("Data has been written.");
        }

        private void btn_createXml_Click(object sender, EventArgs e)
        {
            // create the XmlWriterSettings object 
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; settings.IndentChars = ("   ");
            // create the XmlWriter object 
            XmlWriter xmlOut = XmlWriter.Create(xmlPath, settings);
            // write the start of the document 
            xmlOut.WriteStartDocument(); //xml first line
            xmlOut.WriteStartElement("StudentGrades"); // root element

            FileStream fs1 = new FileStream(txtPath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader txtReader = new StreamReader(fs1);

            // write products into the XML document 
            while (txtReader.Peek() != -1)
            {
                string tempString = "";
                string line = txtReader.ReadLine();
                    tempString += line + "\n";

                    xmlOut.WriteStartElement("Student");
                    xmlOut.WriteElementString("Grade", line);
                    xmlOut.WriteEndElement();
            }
            txtReader.Close();
            fs1.Close();
            // write the end tag for the root element 
            xmlOut.WriteEndElement();

            // close the XmlWriter object 
            xmlOut.Close();
            MessageBox.Show("Data has been written.");
        }

        private void btn_readXml_Click(object sender, EventArgs e)
        {
            // create the XmlReaderSettings object 
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            // create the XmlReader object 
            XmlReader xmlIn = XmlReader.Create(xmlPath, settings);
            string tempStr = "", Data = "";
            // read past all nodes to the first UseInfo node 
            if (xmlIn.ReadToDescendant("Student"))
            {
                // create Data string for each UseInfo node 
                do
                {
                    xmlIn.ReadStartElement("Student");
                    Data = xmlIn.ReadElementContentAsString();
                    tempStr += Data + ", " + "\n";
                }
                while (xmlIn.ReadToNextSibling("Student"));
            }
            // close the XmlReader object 
            xmlIn.Close();
            MessageBox.Show(tempStr);
        }
    }
}

