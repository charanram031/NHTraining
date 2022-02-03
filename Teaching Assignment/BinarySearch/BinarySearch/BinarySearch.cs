using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    //Author: Rc
    //Purpose: Binary search *****/
    internal class Program
    {
        //Implementing using Binarysearch Method
        public static int Binarysearch(int[] a, int s)
        {
            int left = 0;//start
            int right = a.Length - 1;//end
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (s < a[mid])
                {
                    right = mid - 1;
                }

                else if (s > a[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return 0;//if all conditions fails
        }
            
            static void Main(string[] args)
            {
            // Array declaration and Initialisation
            int[] a = new int[] {12,22,23,33,40,57,60,62};
            //search an element in the array
            Console.WriteLine("Enter search element:");
            int s=Convert.ToInt32(Console.ReadLine());
            int result=Binarysearch(a,s);
                if(result<=0)
                {
                    Console.WriteLine($"Search item {s} not found");
                }
                else
                {
                    Console.WriteLine($"Search item {s} Found at index {result}");
                }
            
            

            Console.ReadLine();

        }
    }
}
