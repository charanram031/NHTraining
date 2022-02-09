using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 1, 2,3 }, {4,5,6}, { 5, 6,7 } };
            int sum = 0;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i==j)
                    {
                        sum = sum + data[i, j];
                    }
                }
            }
            Console.WriteLine("Trace of given matrix is {0}",sum);
            Console.ReadLine();
        }
    }
}
