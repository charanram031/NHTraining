using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project5
{
    //Author: Rc
    /**Create  own Class and add variables 
     * and write code to  print name  whose mutuals==1
     * using for,foreach,lambda expression,LINQ
     * *****/
    class Friends //class declaration
    {
        //variables declaration
        public string name;
        public int age;
        public int mutuals;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List creation
            List<Friends> data = new List<Friends>
                { 
                    //initialising  values
                    new Friends() { age= 22, name="RC",mutuals=1},
                    new Friends() { age= 24, name = "Siva",mutuals=1},
                    new Friends() { age= 23, name = "Chandu",mutuals=4},
                    new Friends() { age= 24, name = "Satya",mutuals=5},
                    new Friends() { age= 23, name = "Ramya",mutuals=7}
                };
            //for loop
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].mutuals==1)
                    Console.WriteLine( data[i].name);
            }
            //foreach loop
            foreach (var d in data)
            {
                if (d.mutuals==1)
                    Console.WriteLine(d.name);
            }

            //lambda expression
            data.ToList().Where(e => e.mutuals==1).ToList().ForEach(e => Console.WriteLine(e.name));

            //LINQ

            var result = from e in data
                         where e.mutuals==1
                         select e.name;

            result.ToList().ForEach(d => Console.WriteLine(d));


            Console.ReadLine();
        }
    }
}
