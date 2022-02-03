using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funfact
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            for(int i = 1; i < n; i++)
                fact *= i;
            return fact;
        }
        public static void Print(int n)
        {
            Console.WriteLine("Factorial of {0} = {1}", n, Factorial(n));
        }
        static void Main(string[] args)
        {
            int n = 7, n1 = 6, n2 = 5;
            Print(n);
            Print(n1);
            Print(n2);
            Console.ReadLine();
        }
    }
}
