using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface General // this is the Abstraction interface
    {
        void callRaider();
        void callGuard();
        string command(); // this is the doOperation method
    }
}
