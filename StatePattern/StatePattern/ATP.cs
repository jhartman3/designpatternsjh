using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ATP: Molecule // this is the ConcreteStateA class
    {
        public override bool isEnergized() // this is the handle method
        {
            return true;
        }
    }
}
