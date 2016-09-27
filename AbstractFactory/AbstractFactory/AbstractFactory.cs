using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractFactory // this is the AbstractFactory class
    {
        public abstract AbstractSword createSword(string mater);
        public abstract AbstractShield createShield(string mater);
    }
}
