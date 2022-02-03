using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum=0;
            Console.WriteLine("enter number");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            sn= Convert.ToInt32(Console.ReadLine());
            sum = fn + sn;
            Console.WriteLine("Sum=" + sum);
            Console.ReadLine();
        }
    }
}
