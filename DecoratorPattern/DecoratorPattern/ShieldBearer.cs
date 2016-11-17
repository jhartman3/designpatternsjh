using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ShieldBearer : ArmedKnight // this is the ConcreteDecoratorExtendingState class
    {
        bool defense = false;
        public string attack()
        {
            return "";
        }

        public string defend()
        {
            defense = true;
            return "The knight raises his shield in defense.";
        }

        public string dropDefense()
        {
            defense = false;
            return "The knight lowers his shield to attack.";
        }

        public bool isDefending()
        {
            return defense;
        }
    }
}
