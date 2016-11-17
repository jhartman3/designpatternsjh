using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ArmedKnight : Soldier // this is the Decorator class
    {
        public Soldier fighter = new Swordsman();
        public string attack()
        {
            return fighter.attack();
        }
    }
}
