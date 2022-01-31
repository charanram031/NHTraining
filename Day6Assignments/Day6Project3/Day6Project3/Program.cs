using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("ram");
            data.Add("chandu");
            data.Add("siva");
            data.Add("ramya");
            data.Add("satya");

            //using for loop
            for(int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }

            //using foreach loop
            foreach(var d in data)
            {
                Console.WriteLine(d);
            }

            //using lambda expression
            data.ForEach(p=>Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
