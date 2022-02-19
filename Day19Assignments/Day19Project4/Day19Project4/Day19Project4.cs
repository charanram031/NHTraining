using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter ID:");
            input = Convert.ToInt32(Console.ReadLine());
            XmlDocument obj = new XmlDocument();
            obj.Load("C:\\Users\\admin\\source\\repos\\NHTraining\\Day18Assignments\\Tag.xml");
            foreach (XmlNode obj2 in obj.DocumentElement.ChildNodes)
            {
                foreach (XmlNode obj3 in obj2.ChildNodes)
                {
                    bool id = obj3.Name == "ID";
                    bool isIndex = (id == true ? Convert.ToInt32(obj3.InnerText) : 0) == input;
                    if(id && isIndex)
                    {
                        Console.WriteLine($"{obj3.NextSibling.InnerText}");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
