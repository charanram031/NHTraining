using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funpow
{
    internal class Program
    {
        public static void Print(int a,int b)
        {
            Console.WriteLine("{0} power of {1} is {2}", a, b, Power(a,b));
        }
        public static int Power(int a,int b)
        {
            int pow = 1;
            for(int i = 1; i <=b; i++)
                pow *= a;
            return pow;
        }
        static void Main(string[] args)
        {
            int a1 = 4, b1 = 3, a2 = 5, b2 = 4;
            Print(a1,b1);
            Print(a2,b2);
            Console.ReadLine();
        }
    }
}
