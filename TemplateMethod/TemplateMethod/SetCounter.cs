using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class SetCounter // this is the AbstractClass
    {
        public int calculate(int n, int r) // this is the templateMethod
        {
            if (n < 0 || r > n)
            {
                return -1;
            }
            return getNumerator(n)/getDenominator(n, r);
        }
        public abstract int getNumerator(int n); // this is primitiveOperationA
        public abstract int getDenominator(int n, int r); // this is primitiveOperationB
        public int factorial(int n)
        {
            if (n < 0)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                int a = n;
                n--;
                while (n > 0)
                {
                    a *= n;
                    n--;
                }
                return a;
            }
        }
    }
}
