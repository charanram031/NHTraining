using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class1Library;

namespace PartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division is "+Mathematics.Div(4,2));
            Console.WriteLine("Addition is "+Mathematics.Add(6,4));

            Console.ReadLine();
        }
    }
}
