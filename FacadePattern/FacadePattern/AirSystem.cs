using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class AirSystem // this is a subsystem class
    {
        bool[] coolState = new bool[4]; // state of the cooling units
        bool[] fanState = new bool[4];  // state of the ceiling fans
        // initialize the air system
        public AirSystem()
        {
            for (int i = 0; i < 4; i++)
            {
                coolState[i] = true;
            }
            for (int i = 0; i < 4; i++)
            {
                fanState[i] = true;
            }
        }

        // get the state of the cooling unit at the specified index
        public bool getCoolState(int index)
        {
            return coolState[index];
        }

        // get the state of the fan at the specified index
        public bool getFanState(int index)
        {
            return fanState[index];
        }

        // set the state of the cooling unit at the specified index
        public void setCoolState(int index, bool a)
        {
            coolState[index] = a;
        }

        // set the state of the fan at the specified index
        public void setFanState(int index, bool a)
        {
            fanState[index] = a;
        }
    }
}
