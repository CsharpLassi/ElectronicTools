using NUnit.Framework;
using System;

namespace CSElectronicTools.Test
{
    [TestFixture()]
    public class CylinderVectorTest
    {
        [Test()]
        public void LenghtTest()
        {
            var vec = new CylinderVector(1,1,1);
            Assert.AreEqual(vec.Length(), Math.Sqrt(2), 0.1);
        }

        [Test()]
        public void IsLocalVectorTest()
        {
            var vec = new CylinderVector(1,Math.PI,1);
            Assert.IsFalse(vec.IsLocalVector);

            vec = new CylinderVector(1,0,1);
            Assert.IsTrue(vec.IsLocalVector);
        }

    }
}

