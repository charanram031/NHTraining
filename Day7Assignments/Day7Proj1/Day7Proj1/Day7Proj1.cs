using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project1
{
    //Author: Rc
    /*Purpose:Create Employee class with 3 variables and 2 methods
    and create object and call methods */


    class Employee
    {
        // variable declaration

        private int id;
        private string name;
        private int salary;

        //methods declaration

        public void ReadEmployee()  //To read Employee data from user
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee() //To print Employee data
        {
            Console.WriteLine($"id={id},name={name},salary={salary}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // object creation

            Employee e = new Employee();  //e is object of Employee class

            //calling methods using object

            e.ReadEmployee();
            e.PrintEmployee();

            Console.ReadLine();

        }
    }


}