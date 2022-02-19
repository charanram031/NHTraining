using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project4
{
    //Author : Rc
    //Purpose : ref parameter 
    class Program
    {
        public static void Multi(ref int x)
        {
            x *= x;
            x += x;
            Console.WriteLine("Inside method:"+x);
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Before:"+a);
            Multi(ref a);
            Console.WriteLine("After:"+a);
            Console.ReadLine();
        }
    }
}
