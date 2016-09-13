using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayIterator
{
    public class ForwardIterator : Iterator // this is a ConcreteIterator class
    {
        int index;
        Aggregate a;
        public ForwardIterator(Aggregate agg)
        {
            a = agg;
        }
        public override object first()
        {
            index = 0;
            return currentItem();
        }

        public override object next()
        {
            if (!isDone())
                index++;
            return currentItem();
        }

        public override bool isDone()
        {
            if (index > a.elements.Count - 1)
                return true;
            else
                return false;
        }

        public override object currentItem()
        {
            if (isDone())
                return null;
            else
                return a.elements[index];
        }
    }
}
