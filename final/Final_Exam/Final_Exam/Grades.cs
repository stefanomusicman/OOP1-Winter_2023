using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_Exam
{
    internal class Grades
    {
        private Int16 midTermGrade;
        private Int16 projectGrade;
        private Int16 finalGrade;
        private Int16 totalGrade;

        public Grades() { }

        public Grades(Int16 mid)
        {
            this.midTermGrade = mid;
        }

        public Grades(Int16 mid, Int16 project)
        {
            this.midTermGrade = mid;
            this.projectGrade = project;
        }

        public Grades(Int16 mid, Int16 project, Int16 final)
        {
            this.midTermGrade = mid;
            this.projectGrade = project;
            this.finalGrade = final;
        }

        public Int16 MidTermGrade
        {
            get { return midTermGrade; }
            set { midTermGrade = value; }
        }

        public Int16 ProjectGrade
        {
            get { return projectGrade; }
            set { projectGrade = value; }
        }

        public Int16 FinalGrade
        {
            get { return finalGrade; }
            set { finalGrade = value; }
        }

        public Int16 TotalGrade
        {
            get { return totalGrade; }
            set { totalGrade = value; }
        }

        public Int16 CalcluateMidTermPercentage(Int16 grade)
        {
            Int16 midGrade = Convert.ToInt16((30 * grade) / 100);
            MidTermGrade = midGrade;
            return MidTermGrade;
        }

        public Int16 CalcluateProjectPercentage(Int16 grade)
        {
            Int16 projGrade = Convert.ToInt16((30 * grade) / 100);
            ProjectGrade = projGrade;
            return ProjectGrade;
        }

        public Int16 CalcluateFinalPercentage(Int16 grade)
        {
            Int16 finalGrade = Convert.ToInt16((40 * grade) / 100);
            FinalGrade = finalGrade;
            return FinalGrade;
        }

        public Int16 CalculateTotal()
        {
            //Int16 midTerm, project, final;

            //midTerm = Convert.ToInt16((30 * MidTermGrade) / 100);
            //project = Convert.ToInt16((30 * ProjectGrade) / 100);
            //final = Convert.ToInt16((40 * FinalGrade) / 100);
            //FinalGrade = Convert.ToInt16(final + project + midTerm);
            TotalGrade = Convert.ToInt16(MidTermGrade + ProjectGrade + FinalGrade);
            return TotalGrade;
        }

        public string CalculateLetterGrade()
        {
            if(TotalGrade >= 90 && TotalGrade <= 100)
            {
                return "A";
            } 
            else if(TotalGrade >= 80 && TotalGrade < 90)
            {
                return "B";
            }
            else if (TotalGrade >= 70 && TotalGrade < 80)
            {
                return "C";
            }
            else if (TotalGrade >= 60 && TotalGrade < 70)
            {
                return "D";
            }
            else if (TotalGrade >= 0 && TotalGrade < 60)
            {
                return "F";
            }
            else
            {
                return "NaG";
            }
        }
    }
}
