using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, p=1;
            Console.WriteLine("enter number");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            sn = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=sn;i++)
            {
                p = p * fn;
            }
            Console.WriteLine("Power=" + p);
            Console.ReadLine();
        }
    }
}
