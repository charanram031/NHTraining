using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project2
{
    //Author: Rc 
    /***Purpose: To implement normal properties and auto-implemented properties****/
    class A //normal properties
    {
        private int id;
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
        public int Name 
        {
            set
            {
                Name=value;
            }
        }


    }
    class B //AutoImplemented
    {
        public int Id { get; set; }
        public string Name
        {
            get
            {
                return "Ram";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For normal properties:");
            A a = new A();
            a.Id = 8000;
            Console.WriteLine(a.Id);
            Console.WriteLine("\n");
            Console.WriteLine("For Auto implemented properties");
            //Automated 
            B b = new B();
            b.Id = 50;
            Console.WriteLine("Id : {0}",b.Id);
            Console.WriteLine("Name is {0}",b.Name);            

            Console.ReadLine();
        }
    }
}
