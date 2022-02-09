using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project8
{
    public class Rc
    {
        public static int Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial is : {0} ",Rc.Fact(5));

            Console.ReadLine();
        }
    }
}
