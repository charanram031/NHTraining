using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project4
{
    //Author: Rc
    /**Create Department Class and add variables id,name,empcount
     * and write code to  print id and name  whose emp >50
     * using for,foreach,lambda expression,LINQ
     * *****/
    class Department //class declaration
    {
        //variables declaration
        public int id;
        public string name;
        public int empcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List creation
            List<Department> data = new List<Department>
                { 
                    //initialising  values
                    new Department() { id = 1, name="Developer",empcount=80},
                    new Department() { id = 2, name = "Automation",empcount=60},
                    new Department() { id = 3, name = "Production Support",empcount=40},
                    new Department() { id = 4, name = "Security",empcount=50},
                    new Department() { id = 5, name = "Quality Analyst",empcount=70}
                };
            //for loop
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].empcount > 50)
                    Console.WriteLine("{0} - {1} ", data[i].id, data[i].name);
            }
            //foreach loop
            foreach (var d in data)
            {
                if (d.empcount > 50)
                    Console.WriteLine("{0} = {1} ", d.id, d.name);
            }

            //lambda expression
            data.ToList().Where(e => e.empcount > 50).ToList().ForEach(e => Console.WriteLine("{0} -> {1} ", e.id, e.name));

            //LINQ

            var result = from e in data
                         where e.empcount > 50
                         select e.id + "," + e.name;

            result.ToList().ForEach(d => Console.WriteLine(d));


            Console.ReadLine();
        }
    }
}

