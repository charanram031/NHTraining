using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument obj = new XmlDocument();
            obj.Load("C:\\Users\\admin\\source\\repos\\NHTraining\\Day18Assignments\\Tag.xml");
            foreach(XmlNode obj2 in obj.DocumentElement.ChildNodes)
            {
                foreach(XmlNode obj3 in obj2.ChildNodes)
                {
                    if (obj3.Name == "ID")
                    {
                        Console.Write($"{obj3.InnerText} , ");
                    }
                    if (obj3.Name == "name")
                    {
                        Console.Write($"{obj3.InnerText} , ");
                    }
                    if(obj3.Name=="Price")
                        Console.Write($"{obj3.InnerText} , ");
                    if(obj3.Name=="Brand")
                        Console.Write($"{obj3.InnerText} \n");
                }
            }
            Console.ReadLine();
        }
    }
}
