using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMidTermPrep
{
    internal class ConvertArea
    {
        private Double num;

        public ConvertArea() { }

        public ConvertArea(Double inputNumber)
        {
            this.num = inputNumber;
        }

        public Double Num
        {
            get
            { return num; }
            set
            { num = value; }
        }

        //method for converting from square cm to sqaure inches
        public Double CmToInches()
        {
            return Num * 0.1550;
        }

        // method for converting from sqaure metres to square yards
        public Double MetresToYards()
        {
            return Num * 1.1960;
        }

        // method for converting from hectares to acres
        public Double HecToAcres()
        {
            return Num * 2.4711;
        }

        // method for converting from km to miles
        public Double KmToMiles()
        {
            return Num * 0.3861;
        }
    }
}
