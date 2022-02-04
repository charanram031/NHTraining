using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project1
{ 
    //Author :Rc
    /*Purpose : Single inheritance */
    class A //parent class
    {
        /// <summary>
        /// This method finds sum of 2 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Sum</returns>
        public int Sum(int a,int b)
        {
            return a + b;
        }
        /// <summary>
        /// This method find the Difference
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Difference</returns>
        public int Diff(int a, int b)
        {
            return a - b;
        }
    }
    //child class
    class B : A //B is childclass and A is parent class
    {
        /// <summary>
        /// This method find Product
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Product</returns>
        public int Product(int a, int b)
        {
            return a* b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object creation
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
