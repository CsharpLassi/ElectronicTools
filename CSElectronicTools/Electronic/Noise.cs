using System;

namespace CSElectronicTools.Electronic
{
    public static class Noise
    {
        

        public static double ResistorNoiseVoltage(double resistor, double temperature ,double frequenz)
        {
            return Math.Sqrt(4 * NaturalConstants.BOLTZMANN * temperature * resistor * frequenz);
        }
    }
}

