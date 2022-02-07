using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project1
{
    //Author:Rc
    /*Purpose:Program for interface*/
    /// <summary>
    /// This is interface
    /// </summary>
    interface Ishape
    {
        /// <summary>
        /// This method finds area of given shape
        /// </summary>
        /// <returns>area</returns>
         int Area();
        /// <summary>
        /// This method find perimeter of given shape
        /// </summary>
        /// <returns>perimeter</returns>
         int Perimeter();
    }
    //Class declaration
    class Circle:Ishape
    {
        public int radius;
        /// <summary>
        /// This method is to read data 
        /// </summary>
        public void ReadRadius()
        {
            Console.WriteLine("Enter Radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int Area()
        {
            return 22 * radius * radius / 7;
        }
        public int Perimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }
    class Square : Ishape
    {
        public int side;
        public void ReadSide()
        {
            Console.WriteLine("Enter Side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int Area()
        {
            return side*side;
        }
        public int Perimeter()
        {
            return 4*side;
        }

    }
    class Rectangle : Ishape
    {
        public int l;
        public int b;
        public void ReadData()
        {
            Console.WriteLine("Enter Length:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth:");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int Area()
        {
            return l*b;
        }
        public int Perimeter()
        {
            return 2 * (l+b);
        }

    }
    class Triangle : Ishape
    {
        public int s,a,b,c;
        public void ReadSide()
        {
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = Convert.ToInt32(Console.ReadLine());
            s = (a + b + c) / 2;
        }
        public int Area()
        {
            return (int)Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
        public int Perimeter()
        {
            return 2*s;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c=new Circle();
            c.ReadRadius();
            Console.WriteLine(c.Area());
            Console.WriteLine(c.Perimeter());

            Square s = new Square();
            s.ReadSide();
            Console.WriteLine(s.Area());
            Console.WriteLine(s.Perimeter());

            Rectangle r = new Rectangle();
            r.ReadData();
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimeter());

            Triangle t = new Triangle();
            t.ReadSide();
            Console.WriteLine(t.Area());
            Console.WriteLine(t.Perimeter());

            Console.ReadLine();
        }
    }
}
