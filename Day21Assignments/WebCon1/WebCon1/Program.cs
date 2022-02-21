using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCon1.ServiceReference1;

namespace WebCon1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj=new WebService1SoapClient();
            Console.WriteLine(obj.Add(3, 4));
            Console.WriteLine(obj.Mul(5,6));
            Console.ReadLine();
        }
    }
}