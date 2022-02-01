using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibanocci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter input");
            input=Convert.ToInt32(Console.ReadLine());
            int next = 1;
            int prev = 0;
            for(int i=1;i<=input;i++)
            {
     
               if(next==0)
                {
                    next = 1;
                }
                else
                {
                    int temp = next+prev;
                    prev = next;
                    next = temp;
                }
                Console.WriteLine(prev);
            }
            Console.ReadLine();
        }
    }
}
