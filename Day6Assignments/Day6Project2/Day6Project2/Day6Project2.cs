using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project2
{
    //Author:Rc
    /* Create List<T> and assign some values and find sum
     * **/
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> Declaration ,Here T is integer
            List<int> data = new List<int>();
            int sum = 0;
            //assigning values
            data.Add(2);
            data.Add(35);
            data.Add(55);
            data.Add(18);
            data.Add(20);
            //Find sum using foreach loop
            foreach (var d in data)
            {
                sum = sum + d;
            }
          Console.WriteLine("Sum of values in List is : {0} ",sum);
            Console.ReadLine();
        }
    }
}
