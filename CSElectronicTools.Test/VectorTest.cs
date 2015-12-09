using NUnit.Framework;
using System;

namespace CSElectronicTools.Test
{
    [TestFixture()]
    public class VectorTest
    {
        [Test()]
        public void LenghtTest()
        {
            Vector vec = new Vector(1,1,1);
            Assert.AreEqual(vec.Length(), Math.Sqrt(3), 0.1);
        }

        [Test()]
        public void IsLocalVectorTest()
        {
            Vector vec = new Vector(1,1,1);
            Assert.IsTrue(vec.IsLocalVector);
        }

    }
}

