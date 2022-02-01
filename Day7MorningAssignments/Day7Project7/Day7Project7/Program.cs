using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project7
{
    //Author: Rc
    /**Create Products Class
     * create object and initialise with 5 values
     * and write code to  print Custormers whose count>=2
     * using for, count>=3 using foreach,count>=4 using lambda expression
     * *****/
    class Products //class declaration
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
            Products[] p = new Products[] //array object
            {
               //initialising object with values 
            new Products() { id = 1, name = "Snickers", count=4},
            new Products() { id = 2, name = "Milkybar",count=1},
            new Products() { id = 3, name = "Kitkat", count=3},
            new Products() { id = 4, name = "5 Star",count=6},
            new Products() { id = 5, name = "Dairymilk",count=5}
            };
            //for loop
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].count >= 2)
                    Console.WriteLine($"id={p[i].id},name={p[i].name},Number of Products={p[i].count}");
            }
            //foreach loop
            foreach (var e in p)
            {
                if (e.count >= 3)
                    Console.WriteLine($"id={e.id},name={e.name},No. of products={e.count}");
            }

            //lambda expression
            p.ToList().Where(e => e.count >= 4).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},Num of Products={e.count}"));

            Console.ReadLine();
        }
    }
}
