using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project3
{
    //Author: Rc
    /****Purpose:Print prime numbers using break*****/
    class Prime
    {
        int n,i;
        /// <summary>
        /// This method reads input
        /// </summary>
        public void ReadPrime()
        {
            Console.WriteLine("Enter any num");
            n=Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method prints the data
        /// </summary>
        public void PrintData()
        {
            for( i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (n == i)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not a Prime");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object for above class
            Prime p = new Prime();
            p.ReadPrime();
            p.PrintData();

            Console.ReadLine();
        }
    }
}
