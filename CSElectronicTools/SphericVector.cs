using System;

namespace CSElectronicTools
{
    public class SphericVector : IVector
    {
        public Distance R {
            get;
            set;
        }

        public Angle Phi {
            get;
            set;
        }

        public Angle Theta {
            get;
            set;
        }

        public bool IsLocalVector
        {
            get{ return Phi == 0 && Theta == 0; }
        }
            
        public SphericVector()
        {
            R = 0;
            Phi = 0;
            Theta = 0;
        }

        public SphericVector(Distance r, Angle phi, Angle theta)
        {
            R = r;
            Phi = phi;
            Theta = theta;
        }

        public Distance Length()
        {
            return R;
        }

        public static ScalarValue ScalarProduct(SphericVector v1, SphericVector v2)
        {
            return Vector.ScalarProduct(v1.ToVector(), v2.ToVector());
        }

        public Vector ToVector()
        {
            double x = R * Math.Cos(Phi) * Math.Cos(Theta);
            double y = R * Math.Sin(Phi) * Math.Cos(Theta);
            double z = Math.Sin(Theta);

            return new Vector(x,y,z);
        }
    }
}

