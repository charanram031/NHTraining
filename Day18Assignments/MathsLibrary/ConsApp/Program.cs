using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;


namespace ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Algebra.Factorial(5));
            Console.WriteLine(Algebra.Palindrome(132));

            Console.ReadLine();

        }
    }
}
