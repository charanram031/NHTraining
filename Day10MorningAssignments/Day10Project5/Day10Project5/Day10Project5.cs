using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project5
{
    //Author: Rc
    /*****Purpose:Method Overriding*****/
    class A //parent class
    {
        /// <summary>
        /// This method is details of employee
        /// </summary>
        public void Employee()
        {
            string name = "rc";
            Console.WriteLine("Employee name is {0}",name);
        }
        /// <summary>
        /// This method is name of the company
        /// </summary>
        public virtual void Company()
        {
            Console.WriteLine("DXC Technologies");
        }
        /// <summary>
        /// This method is Id of the employee
        /// </summary>
        public virtual void ID()
        {
            string id = "Dxc001";
            Console.WriteLine("Employee id is {0}", id);
        }
    }
    class B : A//B is sub class and A is super class
    {
        /// <summary>
        /// This method is name of the company
        /// </summary>
        public override void Company()
        {
            Console.WriteLine("NBH Technologies");
        }
        /// <summary>
        /// This method is Id of the employee
        /// </summary>
        public override void ID()
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
            a.Employee();
            Console.WriteLine("Worked in:");
            a.Company();
            a.ID();
            //object creation
            B b = new B();
            Console.WriteLine("Employee Shifted to:");
            b.Company();
            b.ID();

            Console.ReadLine();
        }
    }
}
