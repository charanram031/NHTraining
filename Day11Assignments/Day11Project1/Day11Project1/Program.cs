using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project1
{
    interface Ishape
    {
         int Area();
         int Perimeter();
    }
    class Circle:Ishape
    {
        public int radius;
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
        public int side;
        public void ReadSide()
        {
            Console.WriteLine("Enter side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int Area()
        {
            return (3)^1/2*side*side/4;
        }
        public int Perimeter()
        {
            return 3*side;
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
