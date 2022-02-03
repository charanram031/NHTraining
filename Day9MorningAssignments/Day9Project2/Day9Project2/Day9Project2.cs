using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project2
{
    //Author: Rc
    /*Purpose: Create class and do maths opertaions using objects.**/
    class MathTask
    {
        //variable declaration
        public int a, b;
        /// <summary>
        /// This method reads input from user
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method is to find the sum
        /// </summary>
        /// <returns>sum</returns>
        public int Sum()
        {
            return a + b;
        }
        /// <summary>
        /// This method is to find Difference
        /// </summary>
        /// <returns>Difference</returns>
        public int Difference()
        {
            return a - b;
        }
        /// <summary>
        /// This method is used to Multiply
        /// </summary>
        /// <returns>Prouduct</returns>
        public int Multiply()
        {
            return a * b;
        }
        /// <summary>
        /// This method is used to Divide
        /// </summary>
        /// <returns>Quotient</returns>
        public int Division()
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation
            MathTask obj=new MathTask();
            obj.ReadData();
            Console.WriteLine(obj.Sum());
            Console.WriteLine(obj.Difference());
            Console.WriteLine(obj.Multiply());
            Console.WriteLine(obj.Division());

            Console.ReadLine();

        }
    }
}
