using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermWindowsForm
{
    internal class ConvertLength
    {
        private Double num;

        public ConvertLength() { }

        public ConvertLength(Double number)
        {
            this.num = number;
        }

        public Double Num
        {
            get
            { return num; }
            set
            { num = value; }
        }

        // method for converting to cm
        public Double MetreToCm()
        {
            return Num * 100;
        }

        // method for converting from cm to yards
        public Double MetreToYards()
        {
            return Num * 1.0936;
        }

        // method for converting km to metres
        public Double KmToMetres()
        {
            return Num * 1000;
        }

        // method for returning km to miles
        public Double KmToMiles()
        {
            return Num * 0.6214;
        }
    }
}
