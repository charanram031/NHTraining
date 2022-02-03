using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    //Author: RC
    /********Purpose:Bubble sort implementation*******/
    class Sort //Sort class declaration
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //array Declaration and Initialisation
                int[] a = new int[] {26,4,35,14,78};
                int temp;

                Console.WriteLine("Before Sorting:");
                a.ToList().ForEach(e=>Console.WriteLine(e));
  
                for (int i = 0; i<=a.Length - 2; i++) //this for is for number of iterations
                {
                    for (int j= 0; j<=a.Length-2; j++)//this for loop is to take values in a[i]
                    {
                        if (a[j] > a[j+1])//condition is to check whether to sort or not
                        {
                            temp = a[j+1]; 
                            a[j+1] = a[j];
                            a[j] = temp; 
                        }
                    }
                }
                Console.WriteLine("After sorting:");
                // using foreach loop to print values in the array
                    foreach(var p in a)
                        Console.WriteLine(p);

                 Console.ReadLine();
            }
        }
    }
}
