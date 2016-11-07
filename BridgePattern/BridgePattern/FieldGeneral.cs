using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class FieldGeneral : General // this is the AbstractionImp class
    {
        Captain captain;

        public FieldGeneral()
        {
            captain = new RaidCaptain();
        }

        public void callRaider()
        {
            captain = new RaidCaptain();
        }

        public void callGuard()
        {
            captain = new GuardCaptain();
        }

        public string command()
        {
            return captain.followOrder();
        }
    }
}
