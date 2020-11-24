using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.CustomAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _minValue;
        private int _maxValue;


        public MyRangeAttribute(int min, int max)
        {
            this._maxValue = max;
            this._minValue = min;
        }

        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException();
            }

            int valueObj = (int) obj;
            if (valueObj >= _minValue && valueObj <= _maxValue)
            {
                return true;
            }

            return false;

        }
    }
}
