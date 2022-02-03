using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project1
{ 
    //Author : Rc
    /*Purpose: Create class and object*/
    class MathsOperation
    {
        private int input;
        private int i;
        /// <summary>
        /// This method is to read input from user
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("enter number:");
            input=Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method finds Factorial of a number
        /// </summary>
        /// <returns>factorial</returns>
        public int Factorial()
        {
            int fact = 1;
            for(int i = 1; i <=input; i++)
                fact=fact*i;
            return fact;
        }
        /// <summary>
        /// This method find the factors of a given number.
        /// </summary>
        public void Factors()
        {
            for (i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine("Factors are {0} ",i);
            }
        }
        /// <summary>
        /// This is method is to check whether given is Prime or not
        /// </summary>
        public void Prime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }
            if(count == 2)
                Console.WriteLine("{0} is Prime",input);
            else
                Console.WriteLine("not a prime");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            MathsOperation obj = new MathsOperation();//default Constructor
            obj.ReadData();
            Console.WriteLine(obj.Factorial());
            obj.Factors();
            obj.Prime();

            Console.ReadLine();
        }
    }
}
