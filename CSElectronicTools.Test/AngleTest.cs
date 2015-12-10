using NUnit.Framework;
using System;

namespace CSElectronicTools.Test
{
    [TestFixture()]
    public class AngleTest
    {
        [Test()]
        public void CreateTest()
        {
            Angle ang = Math.PI;
            Assert.AreEqual(ang.Value, Math.PI, 0.1);

            double angvalue = ang;
            Assert.AreEqual(angvalue, Math.PI, 0.1);


        }
    }
}

