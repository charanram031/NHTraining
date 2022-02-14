using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamLibrary
{
    public static class Mathematics
    {
        public static int n;
        
        public static int Fact(int n)
        {
            int fact = 1;
            
            for (int i = 1; i<=n; i++)
                fact *= i;
            return fact;
        }

    }
}
