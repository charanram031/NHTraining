using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rem, sum = 0, number;
            Console.WriteLine("Enter number: ");
            number=Convert.ToInt32(Console.ReadLine());
            int temp = number;
            while(number>0)
            {
                rem = number % 10;
                sum=sum+rem;
                number = number / 10;
               // temp = sum;
            }
            Console.WriteLine("Sum of given {0} is {1} ",temp,sum );
        Console.ReadLine();
        }
    }
}
