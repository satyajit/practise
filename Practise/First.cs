using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    public class First
    {
        public int add(int a, int b)
        {
            return a+b; 
        }
        public int subtract(int a, int b)
        {
            int val = a - b;
            if (val > Int32.MinValue && val < Int32.MaxValue)
                return val;
            else
                throw (new Exception());
           
        }
    }
}
