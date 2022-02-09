using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project1
{
    //Author :Rc
    //Purpose: Declare 2 dimensional array
    internal class Program
    {
        static void Main(string[] args)
        {

            //2 Dimensional array creation
            int[,] data = new int[2,2];
            //Initialising using indexes
            data[0,0] = 1;
            data[0,1] = 2;
            data[1,0] = 3;
            data[1,1] = 4;
            //Printing values of 2-D array
            Console.WriteLine("The values in the 2-D array are:");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(data[i,j]+"  ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
