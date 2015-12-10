using System;

namespace CSElectronicTools
{
    public class ScalarValue  
    {
        protected double _value;

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                SetValue(value);
            }
        }

        public ScalarValue()
        {
        }

        public static implicit operator ScalarValue(double value)
        {
            return new ScalarValue(value);
        }

        public static implicit operator double(ScalarValue value)
        {
            return value.Value;
        }

        public ScalarValue(double value)
        {
            SetValue(value);
        }

        protected virtual void SetValue(double value)
        {
            _value = value;
        }
    }
}

