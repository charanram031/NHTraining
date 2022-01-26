using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach4read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable dec
            int[] data = new int[4];
            // user input
            for(int i=0;i<data.Length;i++)
            {
                Console.WriteLine("Enter number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The numbers entered are:");
            foreach (int d in data)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
