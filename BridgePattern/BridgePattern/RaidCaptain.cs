using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class RaidCaptain : Captain // this is the ConcreteImplementor1 class
    {
        public string followOrder()
        {
            return "We are advancing to take more territory.";
        }
    }
}
