using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project9
{
    //Author : Rc
    /**Purpose: Stack implementation**/
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack creation (Generics)
            Stack<int> s = new Stack<int>();
            //Adding elements into stack
            s.Push(10);
            s.Push(20);
            s.Push(30);
            Console.WriteLine("After push \n");
            Console.WriteLine("Total Count is : ");
            Console.WriteLine(s.Count()); //To get number of elements in stack
            Console.WriteLine("The Deleted element is:");
            Console.WriteLine(s.Pop());
            Console.WriteLine("Top element in stack is :");
            Console.WriteLine(s.Peek());
            Console.WriteLine("After Pop  Count is :");
            Console.WriteLine(s.Count());

            Console.ReadLine();
        }
    }
}
