using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Day19Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String s = File.ReadAllText("C:\\Users\\admin\\source\\repos\\NHTraining\\Day18Assignments\\jsondata.txt");
                Console.WriteLine(s);
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read");
            }
            Console.ReadLine();
        }
    }
}
