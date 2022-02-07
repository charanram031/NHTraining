using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project4
{
    //Author:Rc
    /*Purpose:
     * for maths class create 3 static methods and call in main method*/
    class Maths
    {
        //public static int a = 4;
        //public static int b = 5;
        public static int Add( int a, int b)
        {
            return a + b;
        }
        public static int Mul(int a, int b)
        {
            return (a * b);
        }
        public static int Div(int a, int b)
        {
            return (a / b) ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maths.Add(3,4));
            Console.WriteLine(Maths.Mul(4,2));
            Console.WriteLine(Maths.Div(6, 3));

            Console.ReadLine();
        }
    }
}
