using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] sum = new int[2,2];
            //Reading user input
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter array value at ({i},{j}) : ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix a is : ");
            //printing user input
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            //Reading user input
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter array value at ({i},{j}) : ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix b is : ");
            //printing user input
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("After addition Matrix is :");
            for(int i = 0;i < 2; i++)
            {
                for(int j = 0;j < 2; j++)
                {
                    
                   
                        
                        sum[i,j]=a[i,j]+b[i,j];
                  
                    Console.Write(sum[i,j]+" ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}