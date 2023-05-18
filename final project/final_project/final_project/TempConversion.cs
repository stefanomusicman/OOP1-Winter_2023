using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

 Written by Stefano Proietti
 Student ID: 2012831
 
*/

namespace final_project
{
    internal class TempConversion
    {
        public Double startingAmount;
        public char startingUnit;
        public Double numberInCelcius;
        public System.Windows.Forms.Label label;

        public TempConversion() { }

        public Double DetermineConversion()
        {
            if(startingUnit == 'C')
            {
                numberInCelcius = startingAmount;
                return startingAmount * (9d/5d) + 32d;
            } else
            {
                numberInCelcius = (startingAmount - 32d) * (5d / 9d);
                return (startingAmount - 32d) * (5d / 9d);
            }
        }

        public void DetermineMessage()
        {
            switch(numberInCelcius)
            {
                case 100:
                    label.Text = "Water boils";
                    label.ForeColor = Color.DarkRed;
                    break;
                case 40:
                    label.Text = "Hot Bath";
                    label.ForeColor = Color.Red;
                    break;
                case 37:
                    label.Text = "Body Temperature";
                    label.ForeColor = Color.Yellow;
                    break;
                case 30:
                    label.Text = "Beach Weather";
                    label.ForeColor = Color.Yellow;
                    break;
                case 21:
                    label.Text = "Room Temperature";
                    label.ForeColor = Color.Green;
                    break;
                case 10:
                    label.Text = "Cool Day";
                    label.ForeColor = Color.LightBlue;
                    break;
                case 0:
                    label.Text = "Freezing Point of Water";
                    label.ForeColor = Color.DarkBlue;
                    break;
                case -18:
                    label.Text = "Very Cold Day";
                    label.ForeColor = Color.Blue;
                    break;
                case -40:
                    label.Text = "Extremely Cold Day";
                    label.ForeColor = Color.Blue;
                    break;
            }
        }
    }
}
