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
            Assert.AreEqual(Math.PI,ang.Value,  0.1);

            double angvalue = ang;
            Assert.AreEqual(Math.PI,angvalue,  0.1);
        }

        [Test()]
        public void NullTest()
        {
            Angle ang = 0;
            Assert.IsTrue(ang == 0);
        }
    }
}

