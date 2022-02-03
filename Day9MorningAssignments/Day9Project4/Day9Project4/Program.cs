using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project4
{
    //Author :Rc
    /*Purpose: Create Employee with 2 methods */

    class Employee //Employee Class
    {
        //variable declaration
        public int id;
        public string name;
        public int salary;
        public static string company = "NBH Technologies";
        // default constructor
        public Employee()
        {
            this.id = 0;
            this.name = null;
            this.salary = 0;
        }

        //Constructor
        public Employee(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        /// <summary>
        /// This method reads  input from user
        /// </summary>

        public void ReadData()
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method prints Employee data
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"Employee id : {id}, Employee Name is {name}, Salary = {salary},Company-{company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object1 creation
            Employee emp = new Employee();
            emp.ReadData();
            emp.PrintData();

            Console.ReadLine();
        }
    }
}