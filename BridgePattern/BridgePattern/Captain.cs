using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface Captain // this is the Implementor interface
    {
        string followOrder(); // this is the newOperation method
    }
}
