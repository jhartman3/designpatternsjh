using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LEDFactory : Factory // this is a ConcreteFactory class
    {
        public override LightBulb factoryMethod()
        {
            return new LightDiode();
        }
    }
}
