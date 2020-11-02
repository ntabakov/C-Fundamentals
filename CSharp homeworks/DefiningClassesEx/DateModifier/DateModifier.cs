using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public DateModifier(string one,string two)
        {
            One = DateTime.Parse(one);
            Two = DateTime.Parse(two);

        }

        public DateTime One { get; set; }
        public DateTime Two { get; set; }

        public double CalcDifference(DateTime first, DateTime second)
        {
            return Math.Abs((first - second).TotalDays);
        }
    }
}
