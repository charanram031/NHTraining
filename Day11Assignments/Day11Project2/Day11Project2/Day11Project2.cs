<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project2
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;
         
        public int Id
        {
            get
            {
                return id; 
            }
            set
            { 
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }
        public string Designation
        {
            set
            {
                designation = value;
            }
        }
        public int Salary
        {
            get
            {
                salary=(designation=="S")?30000:60000;
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Designation = "M";
            Console.WriteLine($"Salary ={e.Salary}");

            Console.ReadLine();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project2
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;
         
        public int Id
        {
            get
            {
                return id; 
            }
            set
            { 
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }
        public string Designation
        {
            set
            {
                designation = value;
            }
        }
        public int Salary
        {
            get
            {
                salary=(designation=="S")?30000:60000;
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Designation = "M";
            Console.WriteLine($"Salary ={e.Salary}");

            Console.ReadLine();
        }
    }
}
>>>>>>> 5ff70531abdf116f220522f53bf6664a4dcef157
