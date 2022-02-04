using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project7
{
    //Author : Rc
    /********Purpose: Demonstrating abstract class with Vehicles*********/
    //Abstract Parent class 
    abstract class Vehicle
    {
        /// <summary>
        /// This method is to say usage 
        /// </summary>
        public void Usage()
        {
            Console.WriteLine("Used to Trasport");
        }
        /// <summary>
        /// This method is for suggesting to carry License
        /// </summary>
        public void License()
        {
            Console.WriteLine("Please always carry your License");
        }
        /// <summary>
        /// This method is to print numbers of wheels in a given vehicle
        /// </summary>
        /// <returns>Count of wheels</returns>
        public abstract  int wheels();
    }
    class Bike : Vehicle
    {
        public override int wheels()
        {
            return 2;
        }
    }
    class Auto : Vehicle
    {
        public override int wheels()
        {
            return 3;
        }
    }
    class Car : Vehicle
    {
        public override int wheels()
        {
            return 4;
        }
    }
    class Bus : Vehicle
    {
        public override int wheels()
        {
            return 6;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Bike


            //Auto


            //Car


            //Bus


            Console.WriteLine("Happy Journey:");


            Console.ReadLine();
        }
    }
}
