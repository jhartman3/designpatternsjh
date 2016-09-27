using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class TownSmith : AbstractFactory // this is the ConcreteFactoryB class
    {
        // this is the createProductA function
        public override AbstractSword createSword(string mater)
        {
            AbstractSword sword = new ShortSword(mater);
            sword.sharpenBlade();
            return sword;
        }

        // this is the createProductB function
        public override AbstractShield createShield(string mater)
        {
            AbstractShield shield = new RoundShield(mater);
            shield.polishShield();
            return shield;
        }
    }
}
