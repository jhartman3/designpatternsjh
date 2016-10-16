using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Methane : Component // this is a leaf class
    {
        public override string getName()
        {
            return "Methane";
        }

        public override string getSubName()
        {
            return "Methyl";
        }
    }
}
