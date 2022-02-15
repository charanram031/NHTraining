using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clib1;

namespace Cl2
{
    //Author: Rc
    public class Derived:BaseClass
    {
        /// <summary>
        /// This method is to read values
        /// </summary>
        public void Read()
        {
            a = 4;
            b = 3;
            c = 6;
            d= 5;
            e = 9;
        }
    }

    public class Other
    {
        /// <summary>
        /// This method is to read values
        /// </summary>
        public void Read()
        {
            BaseClass cb = new BaseClass();
            cb.a = 9;
            cb.b = 10;
            cb.c = 11;
            cb.d = 12;
            cb.e = 13;
        }
    }
}
