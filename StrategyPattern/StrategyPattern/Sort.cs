using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface Sort // this is the IStrategy interface
    {
        // this is the behaviorInterface method
        List<int> sortList(List<int> list);
    }
}
