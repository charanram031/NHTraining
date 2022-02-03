using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPrime
{
    internal class Program
    {
        public static void Prime(int input)
        {
            int i;
            for (i = 2; i < input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                Console.WriteLine("{0} is Prime", input);
            else
                Console.WriteLine("{0} is not a Prime", input);
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter input");
            Prime(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
