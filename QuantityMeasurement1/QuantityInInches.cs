using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement1
{
    public class QuantityInInches
    {
        public double inches;
        public QuantityInInches()
        {
        }

        public QuantityInInches(double inches)
        {
            this.inches = inches;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj == this)) return false;
            if (!(obj.GetType() == this.GetType())) return false;
            return (((QuantityInInches)obj).inches == this.inches);
        }
    }
}
