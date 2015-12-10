using System;

namespace CSElectronicTools
{
    public class Angle
    {
        public double Value
        {
            get;
            set;
        }

        public Angle()
        {
        }

        public Angle(double value)
        {
            Value = value;
        }

        public static implicit operator Angle(double value)
        {
            return new Angle(value);
        }

        public static implicit operator double(Angle value)
        {
            return value.Value;
        }

    }
}

