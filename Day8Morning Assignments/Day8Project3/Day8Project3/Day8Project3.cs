using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Day7Project7
    {
        //Author: Rc
        /**Create Products Class and add variables id,name,price,brand
         * and write code to  print name and brand whose price >1000
         * using for,foreach,lambda expression,LINQ
         * *****/
        class Products //class declaration
        {
            //variables declaration
            public int id;
            public string name;
            public int price;
            public string brand;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //List creation
                List<Products> p = new List<Products>
                { 
                    //initialising values
                    new Products() { id = 1, name = "Shirt",brand= "USPA",price=2500},
                    new Products() { id = 2, name = "Shoes",brand="UCB",price=3000},
                    new Products() { id = 3, name = "Shorts",brand="Jockey",price=400},
                    new Products() { id = 4, name = "Watch",brand="WROGN",price=1500},
                    new Products() { id = 5, name = "Dairymilk",brand="Cadbury",price=5}
                };
                //for loop
                for (int i = 0; i < p.Count; i++)
                {
                    if (p[i].price > 1000)
                        Console.WriteLine("{0} = {1} ", p[i].name, p[i].brand);
                }
                //foreach loop
                foreach (var e in p)
                {
                    if (e.price > 1000)
                        Console.WriteLine("{0} = {1} ",e.name,e.brand);
                }

                //lambda expression
                p.ToList().Where(e => e.price > 1000).ToList().ForEach(e => Console.WriteLine("{0} = {1} ", e.name, e.brand));
                 
                //LINQ

                var result=from e in p
                           where e.price>1000
                           select e.name + "," + e.brand;

                result.ToList().ForEach(d => Console.WriteLine(d));


                Console.ReadLine();
            }
        }
    }
}
