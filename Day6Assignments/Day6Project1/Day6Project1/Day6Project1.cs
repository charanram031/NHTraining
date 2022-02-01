using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project1
{
    //Author:Rc
    /*Purpose:Create ArrayList and assign some values and find sum
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList Declaration
            ArrayList data = new ArrayList();
            int sum = 0;
            //Assigning values
            data.Add(5);
            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(60);
            //Finding sum using foreach loop
            foreach(var d in data)
            {
                sum = sum + (int)d;
            }
            Console.WriteLine("Sum of values in ArrayList is {0}",sum);
            Console.ReadLine();
        }
    }
}
