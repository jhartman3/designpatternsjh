using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Spearman : ArmedKnight // this is the ConcreteDecoratorExtendingFunctionality class
    {
        public string attack()
        {
            return fighter.attack();
        }

        public string charge()
        {
            return "The knight charges forward with his spear.";
        }
    }
}
