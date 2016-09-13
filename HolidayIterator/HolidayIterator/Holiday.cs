using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayIterator
{
    // class stores a holiday and the month in which it falls
    public class Holiday
    {
        public int month;   // the month of the holiday
        string name; // the holiday's name
        public Holiday(int newMonth, string newName)
        {
            month = newMonth;
            name  = newName;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
