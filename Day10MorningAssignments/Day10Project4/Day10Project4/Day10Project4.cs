using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project4
{
    //Author: Rc
    /*****Purpose:Method Overriding*****/
    class A //parent class
    {
        string name;
        /// <summary>
        /// This method reads the data
        /// </summary>
      
        public void Reademp()
        {
            
            Console.WriteLine("Enter name:");
            name=Console.ReadLine();
        }
        /// <summary>
        /// This method prints data
        /// </summary>
        public void Printemp()
        {
            Console.WriteLine("Employee name is {0}",name);
        }
        /// <summary>
        /// This method is name of the company
        /// </summary>
        public void Company()
        {
            Console.WriteLine("DXC Technologies");
        }
        /// <summary>
        /// This method is Id of the employee
        /// </summary>
        public void ID()
        {
            string id ="Dxc001";
            Console.WriteLine("Employee id is {0}",id);
        }
    }
    class B : A//B is sub class and A is super class
    {
        /// <summary>
        /// This method is name of the company
        /// </summary>
        public new void Company()
        {
            Console.WriteLine("NBH Technologies");
        }
        /// <summary>
        /// This method is Id of the employee
        /// </summary>
        public new void ID()
        {
            string id = "NBH06";
            Console.WriteLine("Employee id is {0}", id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            A a = new A();
            a.Reademp();
            a.Printemp();
            a.Company();
            a.ID();
            //object creation
            B b = new B();
            Console.WriteLine("Employee Change to :");
            b.Company();
            b.ID();

            Console.ReadLine();
        }
    }
}
