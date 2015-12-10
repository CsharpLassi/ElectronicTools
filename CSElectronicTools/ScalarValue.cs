using System;

namespace CSElectronicTools
{
    public abstract class ScalarValue  
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

