using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BubbleSort : Sort // this is the ConcreteStrategyC class
    {
        public List<int> sortList(List<int> list)
        {
            int limit = list.Count;
            bool hasSwapped = false;
            int temp = list[0];
            for (int i = 0; i < limit; i++)
            {
                if (list[i] < temp)
                {
                    list[i - 1] = list[i];
                    list[i] = temp;
                    hasSwapped = true;
                }
                else
                {
                    temp = list[i];
                }
            }
            if (hasSwapped)
            {
                return sortList(list);
            }
            else{
                return list;
            }
        }
    }
}
