using NUnit.Framework;
using System;
using CSElectronicTools.Electronic;

namespace CSElectronicTools.Test.Electronic
{
    [TestFixture()]
    public class NoiseTest
    {
        [Test()]
        public void ResistorNoiseVoltageTest()
        {
            double resistor = 10000;
            double freq = 1000000;
            double temp = 300;

            double voltage = Noise.ResistorNoiseVoltage(resistor, temp, freq);

            Assert.AreEqual(12.9E-6, voltage, 0.1E-6);
        }
    }
}

