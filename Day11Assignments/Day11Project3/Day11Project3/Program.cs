using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project3
{
    class Employee
    {
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string Designation
        {
            get
            {
                return Designation;
            }
            set
            {
                Designation = "Automation";
            }
        }
        public int Salary 
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = 50000;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1;
            Console.WriteLine(employee.Id);
            employee.Name = "Ram";
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Designation);
            Console.WriteLine(employee.Salary);

            Console.ReadLine();
        }
    }
}
