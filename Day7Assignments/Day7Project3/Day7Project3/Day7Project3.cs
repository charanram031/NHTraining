using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project3
{
    //Author:Rc
    /*Purpose:Create Employee class with 3 public variables.
     * Create Employee object and initialise while craeting and print values.
     ***************/
    class Employee //Class Declaration
    {
        //public variable declaration
        public int id;
        public string name;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object declaration with initialisation
            Employee emp = new Employee() { id = 1, name = "rc", age = 22 };
            Console.WriteLine($"id={emp.id},name={emp.name},age={emp.age}");

            Console.ReadLine();
        }
    }
}
