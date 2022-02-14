using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamLibrary;
using PublicLibrary;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Console.WriteLine("Addition is "+m.Add(5, 6));
            Console.WriteLine("Product is "+m.Product(6,4));

            Physics p = new Physics();
            Console.WriteLine("Final Velocity is "+p.FinalVelocity(5,6,4));

            Console.ReadLine();
        }
    }
}
