using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Project1
{
    //Author:Rc
    /*Purpose: Division program and handle 3 exceptions and add super exception*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b, c;
            try
            {
                Console.WriteLine("enter a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b:");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine(c);
            }
            catch (OverflowException)
            {
                Console.WriteLine("enter numbers between -2147483648 to 2147483647");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Number cant be divided by zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter numbers only");
            }
            catch(Exception)
            {
                Console.WriteLine("Something went wrong, contact Rc");
            }
            finally
            {
                Console.WriteLine("\n \n \n \n \n \nRc's Designed Project");


                Console.ReadLine(); 
            }

        }
    }
}
