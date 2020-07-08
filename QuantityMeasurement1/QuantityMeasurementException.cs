using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement1
{
    class QuantityMeasurementException : Exception
    {
        public ExceptionType objectExceptionType;

        public enum ExceptionType
        {
            NULL_EXCEPTION, 
            DIFFERENT_VALUE
        }
        

        public QuantityMeasurementException(ExceptionType typeOfException)
        {
            this.objectExceptionType = typeOfException;
        }
    }
}
