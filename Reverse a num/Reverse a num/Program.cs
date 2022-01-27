using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,temp,rem,rev=0;
            Console.WriteLine("Enter number");
            n=Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n > 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;

            }
            Console.WriteLine("The reverse of {0} is {1} ", temp, rev);
            Console.ReadLine();
        }
    }
}
