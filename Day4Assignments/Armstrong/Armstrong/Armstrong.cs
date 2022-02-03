using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, rem, sum = 0, temp;
            Console.WriteLine("Enter number");
            number=Convert.ToInt32(Console.ReadLine());
            temp = number;
            while(number>0)
            {
                rem=number%10;
                sum=sum+(rem*rem*rem);
                number=number/10;
            }
            if (temp == sum)
            {
                Console.WriteLine("{0} is Armstrong number ", temp);
            }
            else
            {
                Console.WriteLine("{0} is not Armstrong ", temp);
            }
            Console.ReadLine();
        }
    }
}
