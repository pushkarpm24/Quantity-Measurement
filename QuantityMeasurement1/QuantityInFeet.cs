using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement1
{
    public class QuantityInFeet
    {
        public double feet;

        public QuantityInFeet()
        {
        }

        public QuantityInFeet(double feet)
        {
            this.feet = feet;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj == this)) return false;
            if (!(obj.GetType() == this.GetType())) return false;
            return (((QuantityInFeet)obj).feet == this.feet);
        }
    }
}
