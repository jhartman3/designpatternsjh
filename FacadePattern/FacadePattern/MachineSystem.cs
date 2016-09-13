using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class MachineSystem // this is a subsystem class
    {
        bool active = true;

        // gets the state of the machinery
        public bool getMachineState()
        {
            return active;
        }

        // sets the state of the machinery
        public void setMachineState(bool a)
        {
            active = a;
        }
    }
}
