using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class GuardCaptain : Captain // this is the ConcreteImplementor2 class
    {
        public string followOrder()
        {
            return "We are advancing to defend this area.";
        }
    }
}
