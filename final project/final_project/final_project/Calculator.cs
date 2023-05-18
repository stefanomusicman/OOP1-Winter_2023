using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

 Written by Stefano Proietti
 Student ID: 2012831
 
*/

namespace final_project
{
    internal class Calculator
    {
        public String currentValue;
        public String labelValue;
        public bool isPerformed = false;
        private String txtPath = @"../../textFiles/calculator.txt";
        private Double operand1 = 0;
        private Double operand2 = 0;
        private String op;

        public Calculator() {
            op = null;
            currentValue = "";
        }

        public String CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public void Add(String displayValue)
        {
            CurrentValue = displayValue;
            if(isPerformed == false)
            {
                operand1 = Convert.ToDouble(displayValue);
            }
            op = "+";
            labelValue = $"{operand1} {op}";
        }

        public void Subtract(String displayValue)
        {
            CurrentValue = displayValue;
            if (isPerformed == false)
            {
                operand1 = Convert.ToDouble(displayValue);
            }
            op = "-";
            labelValue = $"{operand1} {op}";
        }

        public void Multiply(String displayValue)
        {
            CurrentValue = displayValue;
            if (isPerformed == false)
            {
                operand1 = Convert.ToDouble(displayValue);
            }
            op = "*";
            labelValue = $"{operand1} {op}";
        }
        
        public void Division(String displayValue)
        {
            CurrentValue = displayValue;
            if (isPerformed == false)
            {
                operand1 = Convert.ToDouble(displayValue);
            }
            op = "/";
            labelValue = $"{operand1} {op}";
        }

        public void WriteToTxt(String result)
        {
            FileStream fs = new FileStream(txtPath, FileMode.Append, FileAccess.Write);
            StreamWriter operationsList = new StreamWriter(fs);
            operationsList.WriteLine($"{operand1} {op} {operand2} = {result}");
            operationsList.Close();
            fs.Close();
        }

        public String Equal(String displayValue)
        {
            isPerformed = true;
            operand2 = Convert.ToDouble(displayValue);
            String result = "";
            switch (op)
            {
                case "+":
                    result =  (operand1 + operand2).ToString();
                    WriteToTxt(result);
                    operand1 = Convert.ToDouble(result);
                    labelValue = $"{operand1} {op}";
                    break;
                case "-":
                    result = (operand1 - operand2).ToString();
                    WriteToTxt(result);
                    operand1 = Convert.ToDouble(result);
                    labelValue = $"{operand1} {op}";
                    break;
                case "*":
                    result = (operand1 * operand2).ToString();
                    WriteToTxt(result);
                    operand1 = Convert.ToDouble(result);
                    labelValue = $"{operand1} {op}";
                    break;
                case "/":
                    result = (operand1 / operand2).ToString();
                    WriteToTxt(result);
                    operand1 = Convert.ToDouble(result);
                    labelValue = $"{operand1} {op}";
                    break;
            } return result;
        }
    }
}
