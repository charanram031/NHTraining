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
        public void Sum(int a,int b)
        {
            //int d=a+b; 
            Console.WriteLine("Sum is {0} ",a+b);
        }
        public void Dif(int a,int b)
        {
            int d= a - b;
            Console.WriteLine("Difference is: {0}",d);
        }
    }
    class B : A //B is child class and A is parent class
    {
        public void Product(int a,int b)
        {
            int d = a * b;
            Console.WriteLine("Product is :{0}",d);
        }
    }
    class C : B //C is child class and B is parent class
    {
        public void PrintHi()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.PrintHi();
            c.Sum(5, 6);
            c.Dif(6,2);
            c.Product(5, 6);

            Console.ReadLine();
        }
    }
}
