using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project4
{
    class A
    {
        string name;
        //string id;
        public void Reademp()
        {
            
            Console.WriteLine("Enter name:");
            name=Console.ReadLine();
        }
        public void Printemp()
        {
            Console.WriteLine("Employee name is {0}",name);
        }
        public void Company()
        {
            Console.WriteLine("DXC Technologies");
        }
        public void ID()
        {
            string id ="Dxc001";
            Console.WriteLine("Employee id is {0}",id);
        }
    }
    class B : A
    {
        public new void Company()
        {
            Console.WriteLine("NBH Technologies");
        }
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
            B b = new B();
            b.Reademp();
            b.Printemp();
            b.Company();
            b.ID();

            Console.ReadLine();
        }
    }
}
