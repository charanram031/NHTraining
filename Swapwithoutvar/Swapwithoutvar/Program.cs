using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapwithoutvar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  a, b;
            Console.WriteLine("Enter a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping {0} {1} ", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swapping {0} {1} ", a, b);
            Console.ReadLine();
        }
    }
}
