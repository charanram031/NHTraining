using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project2
{
    //Author:Rc
    //Purpose:Nullable types
    class Program
    {
        static void Main(string[] args)
        {
            byte? i= null;
            if (i.HasValue)
                Console.WriteLine(i);
            else
                Console.WriteLine("No value");
            Console.WriteLine(i.Value);
            Console.ReadLine();
        }
    }
}
