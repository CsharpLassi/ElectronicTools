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

        public SphericVector ToPolarVector()
        {
            double r = Length();
            double phi = Math.Atan2(Y, X);
            double theta = Math.Acos(Z / r);

            return new SphericVector(r, phi, theta);
        }


        public static Vector operator + (Vector v1 , Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator - (Vector v1 , Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector operator * (Vector v1 , Vector v2)
        {
            return new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        }

        public static Vector operator * (Vector v1 , ScalarValue sv)
        {
            return new Vector(v1.X * sv, v1.Y * sv, v1.Z * sv);
        }

        public static Vector operator / (Vector v1 , Vector v2)
        {
            return new Vector(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
        }

        public static Vector operator / (Vector v1 , ScalarValue sv)
        {
            return new Vector(v1.X / sv, v1.Y / sv, v1.Z / sv);
        }


    }
}

