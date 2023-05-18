using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Validator
    {
        //pulValidator () { }

        public bool ValidateSession(String session)
        {
            Regex regex = new Regex(@"^(Fall|Winter|Summer)$");
            if(regex.IsMatch(session))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool ValidateYear(String year)
        {
            Regex regex = new Regex(@"^(2023|2024|2025)$");
            if (regex.IsMatch(year))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateGrade(String grade)
        {
            Regex regex = new Regex(@"^([1-9]\d?|0|100)$");
            if (regex.IsMatch(grade))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
