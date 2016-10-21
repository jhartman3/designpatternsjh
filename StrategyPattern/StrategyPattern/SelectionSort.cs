using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SelectionSort : Sort // this is the ConcreteStrategyB class
    {
        public List<int> sortList(List<int> list)
        {
            int limit = list.Count;
            int temp = list[0];
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    if (list[j] > temp)
                    {
                        temp = list[j];
                    }
                }
                list.Remove(temp);
                list.Insert(i, temp);
            }
            return list;
        }
    }
}
