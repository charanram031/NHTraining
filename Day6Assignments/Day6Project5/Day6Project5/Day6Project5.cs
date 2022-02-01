using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project5
{
    //Author: Rc
    /*Purpose:Demonstrating Implicit and Explicit type casting
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit 
            short p=10;
            int q=p;
            Console.WriteLine(p);
            Console.WriteLine(q);

            //explicit
            int a = 6;
            short b=Convert.ToInt16(a);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
