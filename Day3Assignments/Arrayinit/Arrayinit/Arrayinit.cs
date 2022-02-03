using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayinit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable initialisation
            int sum = 0,a;
            int[] data = new int[] { 5, 9, 12, 10, 3 };
            foreach(int d in data)
            {
                sum += d;
            }
            a= sum / 5;
            Console.WriteLine("The sum is "+sum);
            Console.WriteLine("Average is "+a); 
            Console.ReadLine();
        }
    }
}
