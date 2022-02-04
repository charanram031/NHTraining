using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project2
{
    //Author :Rc
    /* Multilevel Inheritance*/
    class A //parent class
    {
        /// <summary>
        /// This method find sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Sum(int a,int b)
        {
            Console.WriteLine("Sum is {0} ",a+b);
        }
        /// <summary>
        /// This method find Difference
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Dif(int a,int b)
        {
            
            Console.WriteLine("Difference is: {0}",a-b);

        }
    }
    class B : A //B is child class and A is parent class
    {
        /// <summary>
        /// This method Find Product
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Product(int a,int b)
        {
            
            Console.WriteLine("Product is :{0}",a*b);

        }
    }
    class C : B //C is child class and B is parent class
    {
        /// <summary>
        /// This method used to print the data
        /// </summary>
        public void PrintHi()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            C c = new C();
            c.PrintHi();
            c.Sum(5, 6);
            c.Dif(6,2);
            c.Product(5, 6);

            Console.ReadLine();
        }
    }
}
