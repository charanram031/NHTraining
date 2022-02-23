using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{

    //Author: Ram charan
    //Purpose: Creating app for Employee management
    public static class EmployeeDAL
    {
        public static string filePath = "E:\\R@m\\C#Project\\Employee.txt";
        /// <summary>
        /// This method is to AddEmployee details
        /// </summary>
        /// <param name="eid"></param>
        /// <param name="ename"></param>
        /// <param name="esalary"></param>
        /// <param name="eage"></param>
        /// <returns>true or false</returns>
        public static bool AddEmployee(int eid,string ename,int esalary,int eage)
        {
            //Write Code to append data
            try
            {
                String textContent=String.Concat(eid,",",ename,",",esalary,",",eage);
                File.AppendAllText(filePath, textContent+Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        /// <summary>
        /// This method is used to search employees by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> GetEmpById(int id)
        {
            var allEmployees=File.ReadAllLines(filePath);
            bool isFound=false;
            List<string> employeeFound = new List<string>();
            foreach(string employee in allEmployees)
            {
                var employeeDetails=employee.Split(',');
                if(Convert.ToInt32(employeeDetails[0])==id)
                {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
        /// <summary>
        /// This method is used to search by name
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> GetEmpByName(string name)
        {
            var allEmployees = File.ReadAllLines(filePath);
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var employeeDetails = employee.Split(',');
                if ((employeeDetails[1]).Contains(name))
                {
                    employeeFound.Add(employeeDetails[1]);
                    
                }
            }
            return employeeFound;
        }
        /// <summary>
        /// This method is used to Display all Employees
        /// </summary>
        /// <returns></returns>
        public static string[] DisplayAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filePath);
            return allEmployees;
        }
    }
}
