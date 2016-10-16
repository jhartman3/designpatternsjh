using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Benzene : Component // this is a leaf class
    {
        public override string getName()
        {
            return "Benzene";
        }

        public override string getSubName()
        {
            return "Phenyl";
        }
    }
}
