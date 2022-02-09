using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Porject2
{
    //Author : Rc
    /*Purpose: Declare 2-D of (3,2)*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-D Array creation
            int[,] data = new int[,] { { 1, 2 }, { 3, 4 }, { 5,6} };
            //Printing values in 2-D array
            Console.WriteLine("Values in 2-D array are:");
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

