using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayIterator
{
    public class ConcreteAggregate : Aggregate // this is the ConcreteAggregate class
    {
        // constructor creates the list to store the data
        public ConcreteAggregate()
        {
            elements = new List<Holiday>();
        }
        
        // creates an iterator based on the order to sort
        public override Iterator createIterator()
        {
            if (isReverse)
            {
                return new ReverseIterator(this);
            }
            else
                return new ForwardIterator(this);
        }
    }
}
