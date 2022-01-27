using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arminrange
{
    internal class Program
    {
        public static bool Arm(int number)
        {
            int temp, sum = 0, rem;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (Arm(i))
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
