using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcLibrary;

namespace Day16Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Mathematics class-----\n");

            Mathematics m = new Mathematics();

            m.ReadData();

            Console.WriteLine("\nFactorial is  "+m.Fact());

            Console.WriteLine("\n-------------------------------\n");

            Console.WriteLine("\n*****Chemistry class*****\n");

            Chemistry c = new Chemistry();

            Console.WriteLine("Benzene formula "+c.GetBenzene());

            Console.WriteLine("\nMethane formula is "+c.GetMethane());

            Console.WriteLine("\n Water is "+c.GetWater());

            Console.WriteLine("\n=====Physics class======");

            Physics p = new Physics();

            Console.WriteLine("\n Final velocity is"+p.FinalVelocity(5, 3, 2));


            Console.ReadLine();

        }
    }
}
