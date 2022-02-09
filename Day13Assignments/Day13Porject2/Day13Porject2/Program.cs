using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Porject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 1, 2 }, { 3, 4 }, { 5,6} };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}

