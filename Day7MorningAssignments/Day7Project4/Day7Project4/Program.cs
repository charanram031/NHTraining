using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee[] emp =new Employee[]
           {

            new Employee() { id = 1, name = "rc", salary = 1200},
            new Employee() { id = 2, name = "eswar", salary = 8000},
            new Employee() { id = 3, name = "sai",salary = 4500},
            new Employee() { id = 4, name = "pavan", salary = 5000},
            new Employee() { id = 5, name = "chinna", salary = 2000}
           };
            //for loop
            for(int i=0;i<emp.Length;i++)
            {
                Console.WriteLine($"id={emp[i].id},name={emp[i].name},salary={emp[i].salary}");
            }
            //foreach loop
            foreach(var e in emp)
            {
                Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }

            //lambda
            emp.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));

            Console.ReadLine();
        }
    }
}
