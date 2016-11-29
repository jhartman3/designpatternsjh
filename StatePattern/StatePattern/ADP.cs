using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ADP : Molecule // this is the ConcreteStateB class
    {
        public override bool isEnergized() // this is the handle method
        {
            return false;
        }
    }
}
