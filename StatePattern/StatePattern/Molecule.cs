using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class Molecule // this is the State class
    {
        public abstract bool isEnergized(); // this is the handle method
    }
}
