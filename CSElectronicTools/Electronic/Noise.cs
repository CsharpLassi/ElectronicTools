using System;

namespace CSElectronicTools.Electronic
{
    public static class Noise
    {
        public const double BOLTZMANN = 1.38E-23;

        public static double ResistorNoiseVoltage(double resistor, double temperature ,double frequenz)
        {
            return Math.Sqrt(4 * BOLTZMANN * temperature * resistor * frequenz);
        }
    }
}

