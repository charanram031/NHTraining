using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project3
{
    //Author : Rc
    /*Purpose: Declare a 2-D array of size(3,3) and print trace of array*/ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-D array creation and initialisation
            int[,] data = new int[,] { { 1,2,3 }, { 4,5,6 }, { 5,6,7 } };
            int sum = 0;
            
            //printing trace of 2-D array


            for (int i = 0; i < 3; i++) //rows
            {
                for (int j = 0; j < 3; j++) //columns
                {
                    if(i==j) //Condition for finding trace
                    {
                        sum = sum + data[i, j];
                    }
                }
            }
            Console.WriteLine("Trace of given array is {0}",sum);
            Console.ReadLine();
        }
    }
}
