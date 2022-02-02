using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project2
{
    //Author: Rc
    /**Create Employee Class with 3 variables
     * create List of employees,
     * and write code using for,foreach,lambda expression,LINQ
     * *****/
    class Employee //class declaration
    {
        //variables declaration
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Employees> creation

            List<Employee> emp=new List<Employee>
            {
               //initialising object with values 
            new Employee() { id = 501, name = "rc", salary = 5400},
            new Employee() { id = 502, name = "eswar", salary = 3000},
            new Employee() { id = 503, name = "sai",salary = 6500},
            new Employee() { id = 504, name = "pavan", salary = 5000},
            new Employee() { id = 505, name = "chinna", salary = 7000}
            };
            //for loop
            for (int i = 0; i < emp.Count; i++)
            {
                if(emp[i].salary>5000)
                Console.WriteLine(emp[i].name);
            }
            //foreach loop
            foreach (var e in emp)
            { 
                if(e.salary>5000)
                Console.WriteLine(e.name);
            }

            //lambda expression
            emp.Where(e=>e.salary>5000).ToList().ForEach(e=>Console.WriteLine(e.name));

            //LINQ

            var result = from e in emp
                         where e.salary > 5000
                         select e.name;

            result.ToList().ForEach(e => Console.WriteLine(e));

            Console.ReadLine();
        }
    }
}