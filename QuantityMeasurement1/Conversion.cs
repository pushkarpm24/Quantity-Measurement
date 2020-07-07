using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement1
{
    public class Conversion
    {
        public double ConvertFeetsToInches(double feet)
        {
            return feet * 12;
        }

        public double ConvertInchesToFeets(double inches)
        {
            return inches / 12;
        }
    }
}
