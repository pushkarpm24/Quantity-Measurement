﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement1
{
    public class Conversion
    {
        public bool ConvertIntoFeet(int feets, int inches)
        {
            if(inches/12 == feets)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
