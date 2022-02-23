using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace MyClientApp
{
    public class Program
    {
        public static void AddEmployee()
        {
            //user input
            int id, salary, age;
            string name;
            Console.WriteLine("Enter Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            //call BLL
            var result = EmployeeBLL.AddEmployee(id, name, salary, age);
            if(result)
                Console.WriteLine("Employee Details Saved");
            else
                Console.WriteLine("Error Occured");
        }
        public static void GetEmpById()
        {
            //user input
            int id;
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());
            //call BLL
            var result=EmployeeBLL.GetEmpById(id);
            if(result.Count==0)
                Console.WriteLine("No Records Found");
            else
                result.ForEach(d=>Console.WriteLine(d));
        }
        public static void GetEmpByName()
        {
            //user input
            string name;
            Console.WriteLine("Enter name");
            name=Console.ReadLine();
            //call BLL
            var result=EmployeeBLL.GetEmpByName(name);
            if(result!=null)
                result.ForEach(d => Console.WriteLine(d));
            else
                Console.WriteLine("No Data Found");
        }
        public static void DisplayAllEmployees()
        {
            var result=EmployeeBLL.DisplayAllEmployees();
            result.ToList().ForEach(d => Console.WriteLine(d));
        }
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("Employee Management");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Search Employee By Id");
                Console.WriteLine("3.Search Employee By name");
                Console.WriteLine("4.Display All Employees");
                Console.WriteLine("\nEnter your Choice:");
                ch= Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:AddEmployee();
                           break;
                    case 2:GetEmpById();
                           break;
                    case 3:GetEmpByName();
                           break;
                    case 4:DisplayAllEmployees();
                           break;
                    default:
                        Console.WriteLine("Invalid input");
                           break;

                }
                Console.WriteLine("Do you want to continue (y/n)");
                choice = Console.ReadLine();
            }while(choice.Equals("y"));         
        }
    }
}
