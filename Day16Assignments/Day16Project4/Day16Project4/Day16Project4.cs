using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project4
{
    class Multi
    {
        int n;
        public void ReadData()
        {
            Console.WriteLine("Enter input");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n+"*"+i+"="+n*i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Multi m = new Multi();
            m.ReadData();
            m.Print();

            Console.ReadLine();
        }
    }
}
