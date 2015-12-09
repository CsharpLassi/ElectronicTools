using System;

namespace CSElectronicTools
{
    public class Vector : IVector
    {
        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public double Z
        {
            get;
            set;
        }

        public bool IsLocalVector
        {
            get{ return true; }
        }

        public Vector()
        {
        }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double SqrtLength()
        {
            return X * X + Y * Y + Z * Z;
        }

        public double Length()
        {
            return Math.Sqrt(SqrtLength);
        }

    }
}

