using System;

namespace CSElectronicTools
{
    public class Distance : ScalarValue
    {
        public Distance()
        {
        }

        public Distance(double value)
            : base(value)
        {
            
        }

        public static implicit operator Distance(double value)
        {
            return new Distance(value);
        }

        public static implicit operator double(Distance value)
        {
            return value.Value;
        }


        protected override void SetValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Distance can be not lower then  0");
            }

            base.SetValue(value);
        }
    }
}

