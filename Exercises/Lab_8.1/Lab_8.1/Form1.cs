using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;

namespace Lab_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String xmlFromTxtPath = @"../../XMLFromTxt.xml";
        String xmlFromBinaryPath = @"../../XMLFromBinary.xml";
        String txtPath1 = @"../../TextFile1.txt";
        String txtPath2 = @"../../BinaryFile.dat";
        // regex for product code
        Regex prodCode = new Regex(@"^[A-Z0-9]{4}$");
        // regex for product description
        Regex desc = new Regex(@"^[a-zA-Z0-9!@#$%^&*()_+=[\]{}|;':,.<>/?\\-]{0,50}$");
        // regex for price
        Regex price = new Regex(@"^(?:[1-9]\d{0,2}|0)(?:\.\d{1,2})?$");
        private void button1_Click(object sender, EventArgs e)
        {
            if(prodCode.IsMatch(textBox1.Text) == false)
            {
                MessageBox.Show("Product Code is invalid");
            } 
            else if(desc.IsMatch(textBox2.Text) == false)
            {
                MessageBox.Show("Product Description is invalid");
            }
            else if (price.IsMatch(textBox3.Text) == false)
            {
                MessageBox.Show("Product Price is invalid");
            } 
            else
            {
                // create the XmlWriterSettings object 
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true; settings.IndentChars = ("   ");
                // create the XmlWriter object 
                XmlWriter xmlOut = XmlWriter.Create(xmlFromTxtPath, settings);
                // write the start of the document 
                xmlOut.WriteStartDocument(); //xml first line
                xmlOut.WriteStartElement("Products"); // root element

                FileStream fs = new FileStream(txtPath1, FileMode.Append, FileAccess.Write);
                StreamWriter txtWriter = new StreamWriter(fs);
                txtWriter.Write(textBox1.Text.Trim() + "|");
                txtWriter.Write(textBox2.Text.Trim() + "|");
                txtWriter.WriteLine(textBox3.Text.Trim());
                txtWriter.Close();
                fs.Close();

                FileStream fs1 = new FileStream(txtPath1, FileMode.Open, FileAccess.Read);
                StreamReader txtReader = new StreamReader(fs1);

                // write products into the XML document 
                while(txtReader.Peek() != -1)
                {
                    string line = txtReader.ReadLine();
                    string[] arrLine = line.Split('|');

                    xmlOut.WriteStartElement("Product");
                    xmlOut.WriteElementString("PCode", arrLine[0]);
                    xmlOut.WriteElementString("PDesc", arrLine[1]);
                    xmlOut.WriteElementString("PPrice", arrLine[2]);
                    // write the end tag for the root element 
                    xmlOut.WriteEndElement();
                }
                txtReader.Close();
                fs1.Close();
                // write the end tag for the root element 
                xmlOut.WriteEndElement();

                // close the XmlWriter object 
                xmlOut.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // create the XmlReaderSettings object 
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            // create the XmlReader object 
            XmlReader xmlIn = XmlReader.Create(xmlFromTxtPath, settings);
            string tempStr = "", PCode = "", PDesc = "", PPrice = "";
            // read past all nodes to the first UseName node 
            if (xmlIn.ReadToDescendant("Product"))
            {
                // create FN and LN string for each UseName node 
                do
                {
                    xmlIn.ReadStartElement("Product");
                    PCode = xmlIn.ReadElementContentAsString();
                    PDesc = xmlIn.ReadElementContentAsString();
                    PPrice = xmlIn.ReadElementContentAsString();
                    tempStr += PCode + ", " + PDesc + ", " + PPrice + "\n";
                }
                while (xmlIn.ReadToNextSibling("Product"));
            }
            // close the XmlReader object 
            xmlIn.Close();
            MessageBox.Show(tempStr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (prodCode.IsMatch(textBox1.Text) == false)
            {
                MessageBox.Show("Product Code is invalid");
            }
            else if (desc.IsMatch(textBox2.Text) == false)
            {
                MessageBox.Show("Product Description is invalid");
            }
            else if (price.IsMatch(textBox3.Text) == false)
            {
                MessageBox.Show("Product Price is invalid");
            }
            else
            {
                // create the XmlWriterSettings object 
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true; settings.IndentChars = ("   ");
                // create the XmlWriter object 
                XmlWriter xmlOut = XmlWriter.Create(xmlFromBinaryPath, settings);
                // write the start of the document 
                xmlOut.WriteStartDocument(); //xml first line
                xmlOut.WriteStartElement("Products"); // root element

                FileStream fs = new FileStream(txtPath2, FileMode.Append, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fs);
                binaryWriter.Write(textBox1.Text.Trim());
                binaryWriter.Write(textBox2.Text.Trim());
                binaryWriter.Write(textBox3.Text.Trim());
                binaryWriter.Close();
                fs.Close();

                FileStream fs1 = new FileStream(txtPath2, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fs1);
                string code, desc, price;

                // write products into the XML document 
                while (binaryReader.PeekChar() != -1)
                {
                    code = binaryReader.ReadString();
                    desc = binaryReader.ReadString();
                    price = binaryReader.ReadString();

                    xmlOut.WriteStartElement("Product");
                    xmlOut.WriteElementString("PCode", code);
                    xmlOut.WriteElementString("PDesc", desc);
                    xmlOut.WriteElementString("PPrice", price);
                    // write the end tag for the root element 
                    xmlOut.WriteEndElement();
                }
                binaryReader.Close();
                fs1.Close();
                // write the end tag for the root element 
                xmlOut.WriteEndElement();

                // close the XmlWriter object 
                xmlOut.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // create the XmlReaderSettings object 
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            // create the XmlReader object 
            XmlReader xmlIn = XmlReader.Create(xmlFromBinaryPath, settings);
            string tempStr = "", PCode = "", PDesc = "", PPrice = "";
            // read past all nodes to the first UseName node 
            if (xmlIn.ReadToDescendant("Product"))
            {
                // create FN and LN string for each UseName node 
                do
                {
                    xmlIn.ReadStartElement("Product");
                    PCode = xmlIn.ReadElementContentAsString();
                    PDesc = xmlIn.ReadElementContentAsString();
                    PPrice = xmlIn.ReadElementContentAsString();
                    tempStr += PCode + ", " + PDesc + ", " + PPrice + "\n";
                }
                while (xmlIn.ReadToNextSibling("Product"));
            }
            // close the XmlReader object 
            xmlIn.Close();
            MessageBox.Show(tempStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
