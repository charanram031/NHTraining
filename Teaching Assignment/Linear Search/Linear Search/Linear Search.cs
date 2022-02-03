using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    //Author: Rc
    /******Purpose:Linear Search*******/
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Declaration and Initialisation
            int[] elements = new int[] { 2, 8, 19, 29, 11, 12, 40, 22 };
            
            //Reading user input
            Console.WriteLine("Enter number to search:");
            int num=Convert.ToInt32(Console.ReadLine());
            bool search = false;
            //using for loop , search whether number is found or not

            for ( int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == num)
                {
                    Console.WriteLine($"The number {num},is in index{i},at position {i + 1}");//success
                }
            }

            if (!search)

                Console.WriteLine("The number not found");//if not found
               // Console.WriteLine("Please enter correct number.");
            Console.ReadLine();
        }
    }
}
