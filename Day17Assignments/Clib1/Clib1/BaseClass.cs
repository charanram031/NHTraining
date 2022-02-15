using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clib1
{
    //Author:Rc
    /******Purpose:To show Access Modifiers*********/

    public class BaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        /// <summary>
        /// This method is to Readvalues
        /// </summary>
        public void ReadValues()
        {
            a = 5;
            b = 6;
            c = 7;
            d = 5;
            e = 2;
        }
    }
    public class DerivedClass : BaseClass
    {
        /// <summary>
        /// This method is also to read values
        /// </summary>
         public void Read()
         {
             a = 5;
             b = 6;
             c = 7;
             d = 5;
             e = 2;
         }
    }
    public class OtherClass1
    {
        /// <summary>
        /// This method is to read values
        /// </summary>
        public void ReadData()
        {
            BaseClass obj = new BaseClass();
            obj.a = 5;
            obj.b = 6;
            obj.c = 7;
            obj.d = 8;
            obj.e = 10;
            }
        }
    }
}

