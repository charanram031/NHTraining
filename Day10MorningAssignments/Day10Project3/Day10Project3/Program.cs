using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project3
{
    class MethodOverloading
    {
        public int Add(int a, int b)
        { 
            return a + b; 
        }
        public int Add(int a, int b,int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b,int c,int d)
        {
            return a + b +c + d;
        }
    }
    class MethodOverloading2
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public float Add(float a,float b) 
        { 
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading m= new MethodOverloading();
            Console.WriteLine("sum is {0}",m.Add(1, 2));
            Console.WriteLine("Add is {0}",m.Add(2, 3,4));
            Console.WriteLine("Final add {0}",m.Add(3, 4,5,6));
            MethodOverloading2 m2= new MethodOverloading2();
            Console.WriteLine("Example using int and float:");
            Console.WriteLine("int Sum is {0}",m2.Add(1,2));
            Console.WriteLine("Float Sum is {0}",m2.Add(2.5f, 3.0f));

            Console.ReadLine();
        }
    }
}
