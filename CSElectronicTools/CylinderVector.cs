﻿using System;

namespace CSElectronicTools
{
    public class CylinderVector : IVector
    {
        public double Rho {
            get;
            set;
        }

        public double Phi {
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

        public CylinderVector (double rho, double phi, double z)
        {
            Rho = rho;
            Phi = phi;
            Z = z;
        }

        public double SqrtLength()
        {
            return Rho * Rho + Z * Z;
        }

        public double Length()
        {
            return Math.Sqrt(SqrtLength());
        }
            
    }
}
