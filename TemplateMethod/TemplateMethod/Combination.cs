using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Combination : SetCounter // this is a ConcreteClass
    {
        public override int getNumerator(int n)
        {
            return factorial(n);
        }

        public override int getDenominator(int n, int r)
        {
            return (factorial(r) * factorial(n - r));
        }
    }
}
