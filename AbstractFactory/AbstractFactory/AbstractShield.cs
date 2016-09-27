using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractShield // this is the AbstractProductB class
    {
        public abstract string getShape();
        public abstract string getMaterial();
        public abstract void polishShield();
        public abstract bool isPolished();
    }
}
