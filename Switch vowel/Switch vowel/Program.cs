using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            char input;
            //user input
            Console.WriteLine("Enter character");
            input=Convert.ToChar(Console.ReadLine());
            //logic and output
            switch(input)
            {
                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u':
                    Console.WriteLine("The input  given is vowel "+ input);
                    break;
                default:
                    Console.WriteLine("The input is Consonant "+ input);
                    break ;
            }
            Console.ReadLine();
        }
    }
}
