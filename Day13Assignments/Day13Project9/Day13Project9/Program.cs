using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            Console.WriteLine(s.Count());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Count());

            Console.ReadLine();
        }
    }
}
