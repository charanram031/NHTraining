using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rows for Matrix a");
            int m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Columns for Matrix a");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[m,n];
            Console.WriteLine("Enter Rows for Matrix b");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Columns for Matrix b");
            int q = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[p,q];

            //int[,] c = new int[2,2];
            //Reading user input
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter array value at ({i},{j}) : ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix a is : ");
            //printing user input
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            //Reading user input for B
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.WriteLine($"Enter array value at ({i},{j}) : ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix b is : ");
            //printing user input for B
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
           if(n==p)
            {
                int[,] c = new int[m, q];
                for(int i = 0;i < m; i++)
                {
                    for (int j = 0; j < q; j++)
                    {
                        c[i, j] = 0;

                        for (int k = 0; k < n; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                        Console.Write(c[i, j] + " ");
                    }
                    Console.WriteLine();
                    
                }
                
            }
            else
            {
                Console.WriteLine("No Op:");
            }
            Console.ReadLine();
        }
    }
}
