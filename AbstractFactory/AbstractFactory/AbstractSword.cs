using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractSword // this is the AbstractProductA class
    {
        public abstract int getLength();
        public abstract string getMaterial();
        public abstract void sharpenBlade();
        public abstract bool isSharp();
    }
}
