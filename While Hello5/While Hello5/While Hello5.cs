﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Hello5
{
    /***********
     * print hello 5 times
     * *******/
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine("Hello");
                i++;
            }
            Console.ReadLine();
        }
    }
}
