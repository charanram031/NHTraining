using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project5
{
    public class Palindrome
    {
        
        int sum = 0, rem;
        int num;
        public void ReadData()
        {
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
        }
        
        public void Print()
        {
            int temp = num;
            while (num>0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }
            if(temp==sum)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.ReadData();
            p.Print();

            Console.ReadLine();
        }
    }
}
