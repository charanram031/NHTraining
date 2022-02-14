using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project2
{
    class Mathematics
    {
        public int n;
        
        public  void ReadData()
        {
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public  int Fact()
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.Fact());
            Console.ReadLine();
        }
    }
}
