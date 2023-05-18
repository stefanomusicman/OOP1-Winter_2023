using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
    Stefano Proietti 
    Student number: 2012831
    Date: Tuesday February 28, 2023
*/

namespace ConsoleAppMidTermPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 selection;
            ConvertArea conversion = new ConvertArea();

            do
            {
                Console.WriteLine("Enter the option to convert: ");
                Console.WriteLine("1) for sq cm to sq in");
                Console.WriteLine("2) for sq m to sq yd");
                Console.WriteLine("3) for hectares to acres");
                Console.WriteLine("4) for sq km to sq m");
                Console.WriteLine("5) quit");
                selection = Convert.ToInt16(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        convert: Console.Write("Enter the value to convert: ");
                        try
                        {
                            conversion.Num = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                            goto convert;
                        }
                        Console.WriteLine($"{conversion.Num} sq cm - {conversion.CmToInches()} sq in\n\n");
                        break;
                    case 2:
                        convert2: Console.Write("Enter the value to convert: ");
                        try
                        {
                            conversion.Num = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                            goto convert2;
                        }
                        Console.WriteLine($"{conversion.Num} sq m - {conversion.MetresToYards()} sq yd\n\n");
                        break;
                    case 3:
                        convert3: Console.Write("Enter the value to convert: ");
                        try
                        {
                            conversion.Num = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                            goto convert3;
                        }
                        Console.WriteLine($"{conversion.Num} hectares - {conversion.HecToAcres()} acres\n\n");
                        break;
                    case 4:
                        convert4: Console.Write("Enter the value to convert: ");
                        try
                        {
                            conversion.Num = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                            goto convert4;
                        }
                        Console.WriteLine($"{conversion.Num} sq km - {conversion.KmToMiles()} miles\n\n");
                        break;
                    default:
                        Console.WriteLine("Thank You!");
                        break;
                }
            } while (selection != 5);
        }
    }
}

/* 
 
 result of option 1: converting the number 1 = 0.155
 result of option 2: converting the number 1 = 1.196
 result of option 3: converting the number 1 = 2.4711
 result of option 4: converting the number 1 = 0.3861

 ** all conversions match the ones that are in the example found in the pdf document with instructions **
 
 */
