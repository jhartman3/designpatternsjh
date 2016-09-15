using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class FluorescentBulb : LightBulb // this is a ConcreteProduct class
    {
        int wattage = 15;
        double annualCost = 76.65;
        bool isOn = true;
        public int getWattage()
        {
            return wattage;
        }

        public double getCost()
        {
            return annualCost;
        }

        public void toggleState()
        {
            if (isOn == false)
            {
                isOn = true;
            }
            else
            {
                isOn = false;
            }
        }

        public bool getState()
        {
            return isOn;
        }
    }
}
