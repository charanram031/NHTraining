using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project6
{
    //Author: Rc
    /**Create Customer Class
     * create object and initialise with 5 values
     * and write code to  print customers whose count>=4
     * using for,foreach,lambda expression
     * *****/
    class Customer //class declaration
    {
        //variables declaration
        public int id;
        public string name;
        public int count;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Customer[] c = new Customer[] //array object
            {
               //initialising object with values 
            new Customer() { id = 1, name = "rc", count=4},
            new Customer() { id = 2, name = "eswar",count=1},
            new Customer() { id = 3, name = "sai", count=3},
            new Customer() { id = 4, name = "pavan",count=6},
            new Customer() { id = 5, name = "chinna",count=5}
            };
            //for loop
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].count>=4)
                    Console.WriteLine($"id={c[i].id},name={c[i].name},Customerarrived={c[i].count}");
            }
            //foreach loop
            foreach (var e in c)
            {
                if (e.count>=4)
                    Console.WriteLine($"id={e.id},name={e.name},Customerarrived={e.count}");
            }

            //lambda expression
            c.ToList().Where(e => e.count>=4).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},Customerarrived={e.count}"));

            Console.ReadLine();
        }
    }
}
