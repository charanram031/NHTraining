using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project6
{
    //Author : Rc
    /*****Purpose: Abstraction******/
    /// <summary>
    /// Abstract Parent class 
    /// </summary>
    abstract class Salary
    {
        /// <summary>
        /// This method is to get PF of the employee
        /// </summary>
        /// <param name="basic"></param>
        /// <returns>PF</returns>
        public int GetPf(int basic)
        {
            return 12*basic/100;
        }
        /// <summary>
        /// This method is to get HouseRentalAllowances of the employee
        /// </summary>
        /// <param name="basic"></param>
        /// <returns></returns>
        public int GetHRA(int basic)
        {
            return 40*basic/100;
        }
        /// <summary>
        /// This abstract method is to get ConvenienceAllowances of the employee
        /// </summary>
        /// <returns></returns>
        public abstract int GetCA();
        /// <summary>
        /// This abstract method is to get SpecialAllowances of the employee
        /// </summary>
        /// <returns></returns>
        public abstract int GetSA();
    }
    class Google : Salary
    {
        public  override int GetCA()
        {
            return 4000;
        }
        public override int GetSA()
        {
            return 6000;
        }
    }
    class Microsoft : Salary
    {
        public override int GetCA()
        {
            return 8000;
        }
        public override int GetSA()
        {
            return 4000;
        }
    }
    class IBM : Salary
    {
        public override int GetCA()
        {
            return 10000;
        }
        public override int GetSA()
        {
            return 10000;
        }
    }
    class Facebok : Salary
    {
        public override int GetCA()
        {
            return 2000;
        }
        public override int GetSA()
        {
            return 3000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Google


            //MicroSoft


            //IBM


            //Facebook

            Console.WriteLine("Completed Processing");

            Console.ReadLine();

        }
    }
}
