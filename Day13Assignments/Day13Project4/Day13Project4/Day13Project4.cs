using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project4
{
    //Author: Rc
    /*Purpose: Declare a 2-D array and read values from user*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-D array creation 
            int[,] data = new int[2, 2];
            //Reading user input
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter array value at ({i},{j}) : ");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("2-D array is : ");
            //printing user input
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j]+" ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
