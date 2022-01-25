using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, i;
            //user input
            Console.WriteLine("enter number");
            input=Convert.ToInt32(Console.ReadLine());
            //logic
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(input + "x" + i + "=" + input * i);
            }
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}", input, i, input * i);
            }
            Console.ReadLine();
        }
    }
}
