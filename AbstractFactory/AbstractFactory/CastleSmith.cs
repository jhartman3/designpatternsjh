using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CastleSmith : AbstractFactory // this is the ConcreteFactoryA class
    {
        // this is the CreateProductA function
        public override AbstractSword createSword(string mater)
        {
            AbstractSword sword = new LongSword(mater);
            sword.sharpenBlade();
            return sword;
        }

        // this is the CreateProductB function
        public override AbstractShield createShield(string mater)
        {
            AbstractShield shield = new HeaterShield(mater);
            shield.polishShield();
            return shield;
        }
    }
}
