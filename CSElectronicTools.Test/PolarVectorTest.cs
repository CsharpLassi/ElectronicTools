using NUnit.Framework;
using System;

namespace CSElectronicTools.Test
{
    [TestFixture()]
    public class PolarVectorTest
    {
        [Test()]
        public void LenghtTest()
        {
            var vec = new PolarVector(1,Math.PI/2,Math.PI/2);
            Assert.AreEqual(vec.Length(), 1, 0.1);
        }

        [Test()]
        public void IsLocalVectorTest()
        {
            var vec = new PolarVector(1,Math.PI/2,Math.PI/2);
            Assert.IsFalse(vec.IsLocalVector);

            vec = new PolarVector(1,0,0);
            Assert.IsTrue(vec.IsLocalVector);
        }

        [Test()]
        public void ToVectorTest()
        {
            var vec = new PolarVector(1,Math.PI/2,Math.PI/2);
            var convvec = vec.ToVector();

            Assert.AreEqual(convvec.X, 0, 0.1);
            Assert.AreEqual(convvec.Y, 0, 0.1);
            Assert.AreEqual(convvec.Z, 1, 0.1);
        }
    }
}

