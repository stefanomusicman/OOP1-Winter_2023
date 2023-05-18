using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FinalPrepForm
{
    internal class User
    {
        private string name;
        private string city;
        private Int16 age;

        public User() { }

        public User(string fullName, string userCity, Int16 userAge)
        {
            this.name = fullName;
            this.city = userCity;
            this.age = userAge;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }        
        
        public string City
        {
            get { return city; }
            set { city = value; }
        }        
        
        public Int16 Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool ValidateName(string name)
        {
            Regex rgxName = new Regex(@"^[a-zA-Z]{2}([a-zA-Z\s]){0,48}$");
            if(rgxName.IsMatch(name))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool ValidateCity(string city)
        {
            Regex rgxCity = new Regex(@"(Montreal)|(Toronto)|(Ottawa)");
            if (rgxCity.IsMatch(city))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateAge(string age)
        {
            Regex rgxAge = new Regex(@"^[0-9]{2}$");
            Int16 number = Convert.ToInt16(age);
            if (rgxAge.IsMatch(age) && number >=18 && number <= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AppendToTxt(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine($"Name: {Name}  City: {City}  Age: {Age}");
            writer.Close();
            fs.Close();
        }

        public string ReadTxtCreateXML(string txtpath, string xmlpath)
        {
            // create the XmlWriterSettings object 
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; settings.IndentChars = ("   ");
            // create the XmlWriter object 
            XmlWriter xmlOut = XmlWriter.Create(xmlpath, settings);
            // write the start of the document 
            xmlOut.WriteStartDocument(); //xml first line
            xmlOut.WriteStartElement("UserData"); // root element

            FileStream fs = new FileStream(txtpath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader txtReader = new StreamReader(fs);
            string tempString = "";

            while (txtReader.Peek() != -1)
            {
                string line = txtReader.ReadLine();
                tempString += line + "\n";

                xmlOut.WriteStartElement("UserInfo");
                xmlOut.WriteElementString("Data", line);
                xmlOut.WriteEndElement();
            }

            txtReader.Close();
            fs.Close();
            // write the end tag for the root element 
            xmlOut.WriteEndElement();

            // close the XmlWriter object 
            xmlOut.Close();
            return tempString;
        }

        public string ReadXml(string path)
        {
            // create the XmlReaderSettings object 
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            // create the XmlReader object 
            XmlReader xmlIn = XmlReader.Create(path, settings);
            string tempStr = "", Data = "";
            // read past all nodes to the first UseInfo node 
            if (xmlIn.ReadToDescendant("UserInfo"))
            {
                // create Data string for each UseInfo node 
                do
                {
                    xmlIn.ReadStartElement("UserInfo");
                    Data = xmlIn.ReadElementContentAsString();
                    tempStr += Data + ", " + "\n";
                }
                while (xmlIn.ReadToNextSibling("UserInfo"));
            }
            // close the XmlReader object 
            xmlIn.Close();
            return tempStr;
        }
    }
}
