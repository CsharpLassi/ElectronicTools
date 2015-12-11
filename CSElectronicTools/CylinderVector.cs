using System;

namespace CSElectronicTools
{
    public class CylinderVector : IVector
    {
        public Distance Rho {
            get;
            set;
        }

        public Angle Phi {
            get;
            set;
        }

        public double Z {
            get;
            set;
        }

        public bool IsLocalVector
        {
            get{ return Phi == 0; }
        }

        public CylinderVector ()
        {
            Rho = 0;
            Phi = 0;
        }

        public CylinderVector (Distance rho, Angle phi, double z)
        {
            Rho = rho;
            Phi = phi;
            Z = z;
        }

        public static implicit operator Vector(CylinderVector vec)
        {
            return vec.ToVector();
        }

        public static ScalarValue ScalarProduct(Vector v2,CylinderVector v1)
        {
            return Vector.ScalarProduct(v1, v2);
        }

        public static ScalarValue ScalarProduct(CylinderVector v1, Vector v2)
        {
            return Vector.ScalarProduct(v1, v2);
        }

        public static ScalarValue ScalarProduct(CylinderVector v1, CylinderVector v2)
        {
            return Vector.ScalarProduct(v1, v2);
        }

        public Distance SqrtLength()
        {
            return Rho * Rho + Z * Z;
        }

        public Distance Length()
        {
            return Math.Sqrt(SqrtLength());
        }

        public Vector ToVector()
        {
            double x = Rho * Math.Cos(Phi);
            double y = Rho * Math.Sin(Phi);

            return new Vector(x,y,this.Z);
        }
            
    }
}

