using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[] { 2, 8, 19, 29, 11, 12, 40, 22 };
            Console.WriteLine("Enter number to search:");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == num)
                {
                    Console.WriteLine($"The number {num},is in index{i},at position {i + 1}");
                }
            }
            
            Console.WriteLine("The number not found");
            Console.WriteLine("Please enter correct number:");
            Console.ReadLine();
        }
    }
}
