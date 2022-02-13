using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\C#files\\Rc.txt");
            string data=sr.ReadLine();
            while(data!=null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            Console.WriteLine("\n\n\nReading done");
            Console.ReadLine();
        }
    }
}
