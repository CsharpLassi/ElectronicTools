using NUnit.Framework;
using System;

namespace CSElectronicTools.Test
{
    [TestFixture()]
    public class SphericVectorTest
    {
        [Test()]
        public void LenghtTest()
        {
            var vec = new SphericVector(1,Math.PI/2,Math.PI/2);
            Assert.AreEqual(vec.Length(), 1, 0.1);
        }

        [Test()]
        public void IsLocalVectorTest()
        {
            var vec = new SphericVector(1,Math.PI/2,Math.PI/2);
            Assert.IsFalse(vec.IsLocalVector);

            vec = new SphericVector(1,0,0);
            Assert.IsTrue(vec.IsLocalVector);
        }

        [Test()]
        public void ToVectorTest()
        {
            var vec = new SphericVector(1,Math.PI/2,Math.PI/2);
            var convvec = vec.ToVector();

            Assert.AreEqual(0,convvec.X, 0.1);
            Assert.AreEqual(0,convvec.Y, 0.1);
            Assert.AreEqual(1,convvec.Z, 0.1);
        }
    }
}

