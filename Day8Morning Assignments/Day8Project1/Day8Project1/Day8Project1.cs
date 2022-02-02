using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project1
{
    //Author:Rc
    /*Purpose:Declare and initialisation a list with 8 values,
     * write for ,foreach, lambda ,linq query
     * to print even numbers.
     * ******/
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring and initialising List<integer type>
            List<int> data = new List<int> { 8, 9, 7, 6, 20, 77, 65, 44 };

            //for loop
            for(int i=0;i<data.Count;i++)
            {
                if (data[i] % 2 == 0)
                    Console.WriteLine(data[i]);
            }

            // foreach loop
             
            foreach(var d in data)
            { 
                if (d % 2 == 0)
                    Console.WriteLine(d);
            }

            //Lambda Expression

            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));

            //LINQ

            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();
        }
    }
}
