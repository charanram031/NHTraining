using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project4
{
    //Author: Rc
    /* Declare List<int> and read 5 values from user and find sum using 
     * for loop
     * foreach loop
     * lambda expression
     * **/
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> Declaration
            List<int> data = new List<int>();
            int sum1 = 0,sum2 = 0,sum3 = 0;
            int temp;
             
            //user input
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("enter any number");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }

            //sum using for loop
            for (int i = 0; i < data.Count; i++)
            {
                sum1+=(data[i]);
            }

            //using foreach loop
            foreach (var d in data)
            {
                sum2+=(d);
            }

            //using lambda expression
            data.ForEach(d=> sum3+=d);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);


            Console.ReadLine();
        }
    }
}

