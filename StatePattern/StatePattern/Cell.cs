using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Cell
    {
        List<Molecule> energy;
        public Cell()
        {
            energy = new List<Molecule>();
            for (int i = 0; i < 10; i++)
            {
                energy.Add(new ADP());
            }
        }

        public String getState(int index) // this is the request method
        {
            if (energy[index].isEnergized())
            {
                return "ATP";
            }
            else
            {
                return "ADP";
            }
        }

        public void setState(int index, bool newState)
        {
            if (newState)
            {
                energy[index] = new ATP();
            }
            else
            {
                energy[index] = new ADP();
            }
        }
    }
}
