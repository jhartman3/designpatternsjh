using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Factory
    {
        public abstract LightBulb factoryMethod();
        public LightBulb createBulb() // this is the doSomething function
        {
            LightBulb bulb = factoryMethod();
            bulb.toggleState();
            return bulb;
        }
    }
}
