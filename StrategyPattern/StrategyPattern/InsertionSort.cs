using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class InsertionSort : Sort // this is the ConcreteStrategyA class
    {
        public List<int> sortList(List<int> list)
        {
            int limit = list.Count;
            int smallList = limit;
            int least = list[0];
            List<int> newList = new List<int>();
            for (int j = 0; j < limit; j++)
            {
                for (int i = 0; i < smallList; i++)
                {
                    if (list[i] > least)
                    {
                        least = list[i];
                    }
                }
                newList.Add(least);
                list.Remove(least);
                smallList -= 1;
                least = 0;
            }
            newList.Reverse();
            return newList;
        }
    }
}
