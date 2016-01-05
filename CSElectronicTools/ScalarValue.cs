using System;

namespace CSElectronicTools
{
    public class ScalarValue  
    {
        protected double _value;
        protected int _intvalue;

        public bool IsInteger
        {
            get;
            set;
        }

        public double Value
        {
            get
            {
                if (IsInteger)
                {
                    return _intvalue;
                }

                return _value;
            }
            set
            {
                SetValue(value);
            }
        }

        public int IntValue
        {
            get
            {
                if (!IsInteger)
                {
                    return (int)_value;
                }

                return _intvalue;
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
        public static implicit operator ScalarValue(int value)
        {
            return new ScalarValue(value);
        }

        public static implicit operator double(ScalarValue value)
        {
            return value.Value;
        }

        public static implicit operator int(ScalarValue value)
        {
            return value.IntValue;
        }

        public ScalarValue(double value)
        {
            SetValue(value);
        }

        public ScalarValue(int value)
        {
            SetValue(value);
        }

        protected virtual void SetValue(double value)
        {
            _value = value;
            IsInteger = false;
        }

        protected virtual void SetValue(int value)
        {
            _intvalue = value;
            IsInteger = true;
        }

        public override bool Equals(object obj)
        {

            if (obj is ScalarValue)
                return this.Value == ((ScalarValue)obj).Value;

            return this.Value == ((double)obj);
        }
    }
}

