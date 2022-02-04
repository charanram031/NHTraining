using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project1
{ 
    class A
    {
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public int Diff(int a, int b)
        {
            return a - b;
        }
    }
    class B : A
    {
        public int Product(int a, int b)
        {
            return a* b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine("Product is:");
            Console.WriteLine(b.Product(1,2));
            Console.WriteLine("Sum is:");
            Console.WriteLine(b.Sum(2, 4));
            Console.WriteLine("Difference is:");
            Console.WriteLine(b.Diff(5,1));

            Console.ReadLine();
        }
    }
}
