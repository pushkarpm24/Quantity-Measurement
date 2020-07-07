using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement1
{
    public class Comparision
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

        public bool ConvertIntoYard(double feet, double yards)
        {
            if (feet / 3 == yards)
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
