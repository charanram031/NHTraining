using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, temp, rem, rev = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;

            }
            if(temp==rev)
                Console.WriteLine("The given number {0} is palindrome ", temp);
            else
                Console.WriteLine("The given number {0} is not a palindrome ", temp);
            Console.ReadLine();
        }
    }
}
