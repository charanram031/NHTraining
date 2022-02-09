using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project7
{
    //Author : Rc
    //Purpose :Jagged arrays
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] d = new int[5][];
            d[0]=new int[] {1,2,5};
            d[1]=new int[] {1};
            d[2]=new int[] {3,5};
            d[3]=new int[] {4,6};
            d[4]=new int[] {5,7,8,8,7,5};
            for (int i = 0; i < d.Length; i++)
            {
                for(int j = 0;j<d[i].Length;j++)
                {
                    Console.Write(d[i][j]+"  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
