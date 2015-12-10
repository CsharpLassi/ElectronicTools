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

        public Distance SqrtLength()
        {
            return X * X + Y * Y + Z * Z;
        }

        public Distance Length()
        {
            return Math.Sqrt(SqrtLength());
        }

        public CylinderVector ToCylinderVector()
        {
            double rho = Math.Sqrt(X * X + Y * Y);
            double phi = Math.Atan2(Y, X);

            return new CylinderVector(rho, phi, Z);
        }

        public PolarVector ToPolarVector()
        {
            double rho = Math.Sqrt(X * X + Y * Y + Z * Z);
            double phi = Math.Atan2(Y, X);
            double theta = Math.Atan2(Z, X);

            return new PolarVector(rho, phi, theta);
        }

    }
}

