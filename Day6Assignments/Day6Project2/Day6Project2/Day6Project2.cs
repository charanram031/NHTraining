using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;
            data.Add(2);
            data.Add(35);
            data.Add(55);
            data.Add(18);
            data.Add(20);
            foreach (var d in data)
            {
                sum = sum + d;
            }
          Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
