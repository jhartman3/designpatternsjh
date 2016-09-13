using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayIterator
{
    public abstract class Aggregate // this is the Aggregate class
    {
        public bool isReverse = false;
        public List<Holiday> elements;
        public abstract Iterator createIterator();
    }
}
