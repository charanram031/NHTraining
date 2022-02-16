using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class Algebra
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

            return fact;
        }
        public static string Palindrome(int n)
        {
            int sum = 0, rem;
            int temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if (temp == sum)
                return "Palindrome";
            else
                return "Not Palindrome";
        }
    }
}
