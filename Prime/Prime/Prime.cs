using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable dec
            int input,i,count=0;
            // user input
            Console.WriteLine("Enter Input");
            input = Convert.ToInt32(Console.ReadLine());
            for ( i = 2;i<input;i++)
            {
                if(input%i==0)
                    break;
            }
            if (i == input)
                Console.WriteLine("The given input {0} is Prime ", input);
            else
                Console.WriteLine("The given input {0} is not a prime", input);
            Console.ReadLine();
        }
    }
}
