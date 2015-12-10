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

        }

        public CylinderVector (Distance rho, Angle phi, double z)
        {
            Rho = rho;
            Phi = phi;
            Z = z;
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

