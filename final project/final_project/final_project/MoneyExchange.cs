using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 

All exchange rates were recorded on March 21, 2023
 
*/

/*

 Written by Stefano Proietti
 Student ID: 2012831
 
*/

namespace final_project
{
    internal class MoneyExchange
    {
        public String startingCurrency;
        public String newCurrency;
        public Double startingAmount;
        public Double convertedAmount;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;

        public MoneyExchange() { }

        public Double convert()
        {
            if (startingCurrency == newCurrency)
            {
                textBox2.Text = startingAmount.ToString();
                return startingAmount;
            }
            else if (startingCurrency == "CAD" && newCurrency == "USD")
            {
                convertedAmount = startingAmount * 0.73;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "CAD" && newCurrency == "EUR")
            {
                convertedAmount = startingAmount * 0.68;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "CAD" && newCurrency == "GDP")
            {
                convertedAmount = startingAmount * 0.60;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "CAD" && newCurrency == "DONG")
            {
                convertedAmount = startingAmount * 17227.27;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "USD" && newCurrency == "CAD")
            {
                convertedAmount = startingAmount * 1.73;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "USD" && newCurrency == "EUR")
            {
                convertedAmount = startingAmount * 0.93;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "USD" && newCurrency == "GDP")
            {
                convertedAmount = startingAmount * 0.82;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "USD" && newCurrency == "DONG")
            {
                convertedAmount = startingAmount * 23585;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "EUR" && newCurrency == "CAD")
            {
                convertedAmount = startingAmount * 1.48;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "EUR" && newCurrency == "USD")
            {
                convertedAmount = startingAmount * 1.08;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "EUR" && newCurrency == "GDP")
            {
                convertedAmount = startingAmount * 0.88;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "EUR" && newCurrency == "DONG")
            {
                convertedAmount = startingAmount * 25417.20;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "GDP" && newCurrency == "CAD")
            {
                convertedAmount = startingAmount * 1.88;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "GDP" && newCurrency == "USD")
            {
                convertedAmount = startingAmount * 1.22;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "GDP" && newCurrency == "EUR")
            {
                convertedAmount = startingAmount * 1.13;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "GDP" && newCurrency == "DONG")
            {
                convertedAmount = startingAmount * 28816.51;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "DONG" && newCurrency == "CAD")
            {
                convertedAmount = startingAmount * 0.000058;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "DONG" && newCurrency == "USD")
            {
                convertedAmount = startingAmount * 0.000042;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "DONG" && newCurrency == "EUR")
            {
                convertedAmount = startingAmount * 0.000039;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else if (startingCurrency == "DONG" && newCurrency == "GDP")
            {
                convertedAmount = startingAmount * 0.000035;
                textBox2.Text = convertedAmount.ToString();
                return convertedAmount;
            }
            else
            {
                return 0;
            }
        }
    }
}
