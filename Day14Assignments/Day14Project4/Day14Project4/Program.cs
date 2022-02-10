using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project4
{
    //Author:Rc
    /*Purpose:Print numbers from 1-30 and skip numbers divided by 3*/
    class Div
    {
        int i;
        public void Print()
        {
            for(i=1;i<=30;i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Div div = new Div();
            div.Print();

            Console.ReadLine(); 
        }
    }
}
