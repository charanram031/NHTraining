using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project2
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
                    //var name = obj3.Name == "Name";
                    if(obj3.Name=="Name")
                        Console.WriteLine(obj3.InnerText);
                }
                
            }
            Console.ReadLine();
        }
    }
}
