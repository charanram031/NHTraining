using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project10
{
    //Author :Rc
    /*Purpose: Implementation of Queue*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue Declaration
            Queue<int> queue = new Queue<int>();
            //Adding elements into queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("After adding \n");
            Console.WriteLine("Total count is:");
            Console.WriteLine(queue.Count());
            Console.WriteLine("Deleted num is :");
            Console.WriteLine(queue.Dequeue());// Deleting element from queue
            Console.WriteLine("Top Element is:");
            Console.WriteLine(queue.Peek());
            Console.WriteLine("After deleting Count is :");
            Console.WriteLine(queue.Count());

            Console.ReadLine();
        }
    }
}
