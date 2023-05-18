using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 

Mid-Term Console Application
Stefano Proietti
Student Number: 2012831
Date: March 3, 2023
 
 */

namespace MidTermConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 selection;
            ConvertLength conversion = new ConvertLength();

            do
            {
                Console.WriteLine("Enter 1 for 1st conversion");
                Console.WriteLine("Enter 2 for 2nd conversion");
                Console.WriteLine("Enter 3 for exit");

                checkSelection: Console.Write("Enter your option: ");
                try
                {
                    selection = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception ex1)
                {
                    Console.WriteLine(ex1.Message);
                    goto checkSelection;
                }

                switch(selection)
                {
                    case 1:
                        checkValue: Console.Write("Enter the number to be converted: ");
                        try
                        {
                            conversion.Num = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                            goto checkValue;
                        }
                        Console.WriteLine("{0,0}m is {1,0}cm = {2,0} yards\n\n", conversion.Num, conversion.MetreToCm(), conversion.MetreToYards());
                        break;
                    case 2:
                        checkValue2: Console.Write("Enter the number to be converted: ");
                        try
                        {
                            conversion.Num = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                            goto checkValue2;
                        }
                        Console.WriteLine("{0,0}km is {1,0}m = {2,0} miles\n\n", conversion.Num, conversion.KmToMetres(), conversion.KmToMiles());
                        break;
                    default:
                        Console.WriteLine("Thank You!");
                        break;
                }
            } while (selection != 3);
        }
    }
}
