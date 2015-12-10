using System;

namespace CSElectronicTools
{
    public class PolarVector : IVector
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
            
        public PolarVector()
        {
            R = 0;
            Phi = 0;
            Theta = 0;
        }

        public PolarVector(Distance r, Angle phi, Angle theta)
        {
            R = r;
            Phi = phi;
            Theta = theta;
        }

        public Distance Length()
        {
            return R;
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

