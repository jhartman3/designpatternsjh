using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class IncandescentBulb : LightBulb // this is a ConcreteProduct class
    {
        int wattage = 60;
        double annualCost = 328.59;
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
