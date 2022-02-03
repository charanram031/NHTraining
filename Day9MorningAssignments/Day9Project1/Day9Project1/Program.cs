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
        public void ReadData()
        {
            Console.WriteLine("enter number:");
            input=Convert.ToInt32(Console.ReadLine());
        }
        public int Factorial()
        {
            int fact = 1;
            for(int i = 1; i <=input; i++)
                fact=fact*i;
            return fact;
        }
        public void Factors()
        {
            for (i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine("Factors are {0} ",i);
            }
        }
        public void Prime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }
            if(count == 2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("not a prime");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperation obj = new MathsOperation();
            obj.ReadData();
            Console.WriteLine(obj.Factorial());
            obj.Factors();
            obj.Prime();

            Console.ReadLine();
        }
    }
}
