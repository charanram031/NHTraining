using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project1
{
    //Author:Rc
    /****Purpose:Sealed class Implementation****/
    sealed class Rc
    {
        private int age;//private variables
        public int id { get; set; } //Property
        public static string name="Ram"; //Static variables
        public void Surya() //Method
        {
            Console.WriteLine("Hi Surya");
            Console.WriteLine("Id is:{0}",id = 2);
            Console.WriteLine("Age is:{0}",age=22);    
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rc r=new Rc();
            r.Surya();
            Console.WriteLine("Common friend is : {0}",Rc.name);

            Console.ReadLine();
        }
    }
}
