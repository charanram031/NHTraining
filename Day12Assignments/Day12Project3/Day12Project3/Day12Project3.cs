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
            //Variables declaration
            int a, b, c;
            try
            {
                Console.WriteLine("enter a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b:");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine("Division of 2 numbers is {0}", c);


            }
            catch (OverflowException) //It occurs when numbers are greater than range
            {
                Console.WriteLine("enter numbers between -2147483648 to 2147483647");

            }
            catch (DivideByZeroException)//If number is divided by 0
            {
                Console.WriteLine("Number cant be divided by zero");

            }
            catch (FormatException)//If we enter wrong input like alphabets
            {
                Console.WriteLine("Enter numbers only");

            }
            catch (Exception)//It is the super exception
            {
                Console.WriteLine("Something went wrong, contact Rc");

            }
            finally
            {
                Console.WriteLine("\n \n \n \n \n Designed by Rc");
                Console.ReadLine();
            }
        }
    }
}
