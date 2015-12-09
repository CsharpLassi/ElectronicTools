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

        [Test()]
        public void ToVectorTest()
        {
            var vec = new CylinderVector(Math.Sqrt(2),Math.PI/4,1);
            var convvec = vec.ToVector();

            Assert.AreEqual(convvec.X, 1, 0.1);
            Assert.AreEqual(convvec.Y, 1, 0.1);
            Assert.AreEqual(convvec.Z, vec.Z, 0.1);


        }

    }
}

