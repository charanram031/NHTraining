using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project1
{
    //Author:Rc
    /*Purpose: File methods*/
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StreamWriter sw = new StreamWriter("C:\\C#files\\Rc.txt",true);
            sw.WriteLine("Programming");
            sw.WriteLine("using .Net");
            sw.Close();

            //File.Copy("C:\\C#files\\Rc.txt", "C:\\MainC#\\Hi.txt");
            Console.WriteLine("Appended");
            // Console.WriteLine(File.GetCreationTime("C:\\C#files\\Hi.txt"));
            // File.Delete("C:\\MainC#\\Hi.txt");

            //Console.WriteLine(File.GetLastAccessTime("C:\\C#files\\Hi.txt"));
            //Console.WriteLine("Delete Done");
            // Console.WriteLine(File.GetLastWriteTime("C:\\C#files\\Hi.txt"));
            //File.Encrypt("C:\\C#files\\Hi.txt");
            //File.Create("C:\\C#files\\Hello.txt");
            /* Console.WriteLine("Created");
              if (File.Exists("C:\\C#files\\Rc.txt"))
                  File.Delete("C:\\C#files\\Rc.txt");
              File.Move("C:\\C#files\\Hello.txt", "C:\\C#files\\Rc.txt");
              Console.WriteLine("Moved");*/
            //object read = File.ReadAllText("C:\\C#files\\Rc.txt");
            //Console.WriteLine(read);

           

            Console.ReadLine();
        }
    }
}
