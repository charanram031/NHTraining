using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1Library;

namespace PartialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition is "+Maths.Add(3,4));
            Console.WriteLine("Division is "+Maths.Div(4,2));

            Console.ReadLine();
        }
    }
}
