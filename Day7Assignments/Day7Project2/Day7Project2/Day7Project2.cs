using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project2
{
    //Author:Rc
    /*Purpose:create Classes:
     * customer
     * product
     * seller
     * department
     */
    class Customer   //Class Declaration
    {
        //variable Declaration
        private int cid;
        private string cname;
        private int cnumber;

        //Methods Declaration
        public void ReadCustomer()  //To read input from user
        {
            Console.WriteLine("Enter Customer id:");
            cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customername:");
            cname = Console.ReadLine();
            Console.WriteLine("Enter Customer mobile number:");
            cnumber = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintCustomer() //To print Customer data
        {
            Console.WriteLine($"CustomerId={cid}, Customername={cname}, Mobile number={cnumber}");
        }
    }
    class Products  //Class Declaration
    {
        //variable Declaration
        private int pid;
        private string pname;
        private string pdes;

        //Methods Declaration
        public void ReadProduct()  //To read input from user
        {
            Console.WriteLine("Enter Product id:");
            pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Productname:");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Type of product:");
            pdes = Console.ReadLine();
        }
        public void PrintProduct() //To print Product data
        {
            Console.WriteLine($"ProductId={pid}, Productname={pname}, ProductType={pdes}");
        }
    }
    class Seller   //Class Declaration
    {
        //variable Declaration
        private int sid;
        private string sname;
        private int snumber;

        //Methods Declaration
        public void ReadCustomer()  //To read input from user
        {
            Console.WriteLine("Enter Seller id:");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Seller name:");
            sname = Console.ReadLine();
            Console.WriteLine("Enter Seller mobile number:");
            snumber = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintCustomer() //To print Seller data
        {
            Console.WriteLine($"SellerId={sid}, Sellername={sname}, SellerMobile number={snumber}");
        }
    }
    class Department  //Class Declaration
    {
        //variable Declaration
        private int did;
        private string dname;
        private int dnumber;
        private string ddes;

        //Methods Declaration
        public void ReadCustomer()  //To read input from user
        {
            Console.WriteLine("Enter Department id:");
            did = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Department name:");
            dname = Console.ReadLine();
            Console.WriteLine("Enter  Department mobile number:");
            dnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Department Description: ");
            ddes = Console.ReadLine();
        }
        public void PrintCustomer() //To print Department data
        {
            Console.WriteLine($" DepartmentId={did}, Departmentname={dname}, Mobile number={dnumber}, DepartmentDescription={ddes}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer();
            a.ReadCustomer();
            a.PrintCustomer();
            Products b = new Products();
            b.ReadProduct();
            b.PrintProduct();
            Seller c = new Seller();
            c.ReadCustomer();
            c.PrintCustomer();
            Department i = new Department();
            i.ReadCustomer();
            i.PrintCustomer();

            Console.ReadLine();        }
    }
}
