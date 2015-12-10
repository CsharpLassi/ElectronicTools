using System;

namespace CSElectronicTools
{
    public class Angle : ScalarValue
    {
        public Angle()
        {
        }

        public Angle(double value)
            : base(value)
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

