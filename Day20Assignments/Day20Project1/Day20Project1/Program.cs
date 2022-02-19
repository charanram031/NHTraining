using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project1
{
    //Author: Rc
    //Purpose:Scope of variables

        class Program
        {
        public delegate void MyCaller(int a, int b);
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static  void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
           {
            Console.WriteLine("Output1:");
            MyCaller mc = new MyCaller(Add);
            mc += Mul;
            mc(5, 6);
            Console.WriteLine("Output2:");
            mc += Sub;
            mc(4, 4);
            Console.WriteLine("Output3:");
            mc -= Mul;
            mc(5, 2);
            Console.ReadLine();

           }
        }
}
