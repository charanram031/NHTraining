using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project2
{
    //Author: Rc 
    /***Purpose: To implement normal properties****/
    class A
    {
        private int id;
        private string name;
        private int s;
        public int Id { get; set; }
        public int Name 
        {
            set
            {
                s=value;
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Id = 8000;
            Console.WriteLine("Id is :{0}",a.Id);
            

            Console.ReadLine();
        }
    }
}
