using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;

namespace BusinessLogicLibrary
{
    public static class EmployeeBLL
    {
        public static bool AddEmployee(int eid,string ename,int esalary,int age)
        {
             //To do


            //all Success then call DAL
            var result=EmployeeDAL.AddEmployee(eid,ename,esalary,age);
            return result;
        }
        public static List<string> GetEmpById(int id)
        {
            var result=EmployeeDAL.GetEmpById(id);
            return result;
        }
        public  static List<string> GetEmpByName(string name)
        {
            var result= EmployeeDAL.GetEmpByName(name);
            return result;
        }
        public static string[] DisplayAllEmployees()
        {
            var result=EmployeeDAL.DisplayAllEmployees();
            return result;
        }


    }
}
