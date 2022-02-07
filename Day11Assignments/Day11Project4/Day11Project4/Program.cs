using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project4
{
    class Maths
    {
        public static int a = 4;
        public static int b = 5;
        public static int Add()
        {
            return a + b;
        }
        public static int Mul()
        {
            return (a * b);
        }
        public static int Div()
        {
            return (a / b) ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maths.Add());
            Console.WriteLine(Maths.Mul());
            Console.WriteLine(Maths.Div());

            Console.ReadLine();
        }
    }
}
