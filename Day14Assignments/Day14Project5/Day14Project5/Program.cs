using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project5
{
    //Author:Rc
    /*Purpose :find first number after 1000 which is divided by 97*/
    class Find
    {
        int i;
        public void Print()
        {
            for(i=1000;i<=1097;i++)
            {
                if (i % 97 == 0)
                    break;              
            }
            Console.WriteLine(i);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Find find = new Find();
            find.Print();

            Console.ReadLine();
        }
    }
}
