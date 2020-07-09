﻿using System;
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
            catch (Exception)
            {
                throw new Exception();
            }            

        }

        public static double LiterConversion(double value, string unit)
        {
            try
            {
                switch (unit)
                {
                    case null:
                        throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.NULL_EXCEPTION);                   
                    case "gallon":
                        return value * 3.785;
                    case "ml":
                        return value / 1000;
                    case "litre":
                        return value;
                    default:
                        throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.DIFFERENT_VALUE);
                }
            }
            catch (Exception)
            {
                throw new Exception();
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
