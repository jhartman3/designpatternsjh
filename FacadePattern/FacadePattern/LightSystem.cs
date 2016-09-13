using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class LightSystem // this is a subsystem class
    {
        bool[] state = new bool[5]; // state of the lights
        // initialize the light system
        public LightSystem()
        {
            for (int i = 0; i < 5; i++)
            {
                state[i] = true;
            }
        }

        // gets the state of the light at the specified index
        public bool getLightState(int index)
        {
            return state[index];
        }

        // sets the state of the specified light
        public void setLightState(int index, bool a)
        {
            state[index] = a;
        }
    }
}
