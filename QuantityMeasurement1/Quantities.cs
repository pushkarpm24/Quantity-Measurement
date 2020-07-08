using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement1
{
    public class Quantities : Exception
    {
        public static double IncheConversion(double value, string unit)
        {
            try
            {
                switch (unit)
                {
                    case null:
                        throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.NULL_EXCEPTION);
                    case "feet":
                        return value * 12;
                    case "yards":
                        return value * 36;
                    case "cm":
                        return value/2.5;
                    case "inches":
                        return value;
                    default:
                        throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.DIFFERENT_VALUE);
                }
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.NULL_EXCEPTION);
            }            

        }

        public static bool Addition(double valueOne, double valueTwo, double expectedValue)
        {
            double result = valueOne + valueTwo;
            if (result == expectedValue)
            {
                return true;
            }
            return false;
        }
    }
}
