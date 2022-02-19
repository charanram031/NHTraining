using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project3
{
    //Author:Rc
    /*Purpose:Out parameters  (Call By Value)*/

    class Program
    {
        public static void Arun(out int p, out int q)
        {
            p = 30;
            q = 40;
            //p += q;
            //q += q;
        }
        static void Main(string[] args)
        {
            int i, j;
            Arun(out i, out j);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();

        }
    }
}
