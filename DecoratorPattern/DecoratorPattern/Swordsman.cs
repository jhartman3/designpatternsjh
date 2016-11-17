using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Swordsman : Soldier // this is the ConcreteComponent class
    {
        public string attack()
        {
            return "The knight stabs forward with his weapon.";
        }
    }
}
