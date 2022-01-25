using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, i;
            //user input
            Console.WriteLine("enter any number");
            input=Convert.ToInt32(Console.ReadLine());
            //logic
            for(i=1;i<=input;i++)
            {
                if(input%i==0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
