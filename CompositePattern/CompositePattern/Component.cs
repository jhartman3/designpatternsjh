using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Component // this is the component class
    {
        public abstract string getName();
        public abstract string getSubName();
    }
}
