using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Day19Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument obj = new XmlDocument();
            obj.Load("C:\\Users\\admin\\source\\repos\\NHTraining\\Day18Assignments\\Tag.xml");
            foreach(XmlNode obj2 in obj.DocumentElement.ChildNodes)
            {
                Console.WriteLine(obj2.InnerText);
            }
            Console.ReadLine();
        }
    }
}
