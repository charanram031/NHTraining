using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_in_Range
{
    internal class Program
    {
        public static bool Prime(int input)
        {
            int i;
            for (i = 2; i < input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int i,a, b;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            for (i=a;i<=b;i++)
            {
                if (Prime(i))
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
