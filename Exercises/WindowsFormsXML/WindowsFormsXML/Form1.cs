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

namespace WindowsFormsXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String path = @"../../XMLFile1.xml";

        private void button1_Click(object sender, EventArgs e)
        {
            // create the XmlWriterSettings object 
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; settings.IndentChars = ("   ");
            // create the XmlWriter object 
            XmlWriter xmlOut = XmlWriter.Create(path, settings);
            // write the start of the document 
            xmlOut.WriteStartDocument(); //xml first line
            xmlOut.WriteStartElement("Users"); // root element
            // write username into the XML document 
            {
                xmlOut.WriteStartElement("UserName");
                xmlOut.WriteElementString("FName", textBox1.Text.Trim());
                xmlOut.WriteElementString("LName", textBox2.Text.Trim());
                // write the end tag for the root element 
                xmlOut.WriteEndElement();
            }
            // write the end tag for the root element 
            xmlOut.WriteEndElement();

            // close the XmlWriter object 
            xmlOut.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // create the XmlReaderSettings object 
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            // create the XmlReader object 
            XmlReader xmlIn = XmlReader.Create(path, settings);
            string tempStr = "", FN = "", LN = "";
            // read past all nodes to the first UseName node 
            if (xmlIn.ReadToDescendant("UserName"))
            {
                // create FN and LN string for each UseName node 
                do
                {
                    xmlIn.ReadStartElement("UserName");
                    FN = xmlIn.ReadElementContentAsString();
                    LN = xmlIn.ReadElementContentAsString();
                    tempStr += FN + ", " + LN + "\n";
                }
                while (xmlIn.ReadToNextSibling("UserName"));
            }
            // close the XmlReader object 
            xmlIn.Close();
            MessageBox.Show(tempStr);
        }
    }
}
