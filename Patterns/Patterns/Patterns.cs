﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,j;
            Console.WriteLine("Enter no. of rows");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
