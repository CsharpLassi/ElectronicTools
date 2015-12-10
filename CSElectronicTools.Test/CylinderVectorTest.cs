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
            Assert.AreEqual(Math.Sqrt(2),vec.Length(), 0.1);
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

            Assert.AreEqual(1,convvec.X, 0.1);
            Assert.AreEqual(1,convvec.Y, 0.1);
            Assert.AreEqual(vec.Z,convvec.Z, 0.1);

            vec = new CylinderVector(Math.Sqrt(1),Math.PI/2,1);
            convvec = vec.ToVector();

            Assert.AreEqual(0,convvec.X,  0.1);
            Assert.AreEqual(1,convvec.Y,  0.1);
            Assert.AreEqual(vec.Z,convvec.Z,  0.1);

            vec = new CylinderVector(Math.Sqrt(1),-Math.PI/2,1);
            convvec = vec.ToVector();

            Assert.AreEqual(0,convvec.X,  0.1);
            Assert.AreEqual(-1,convvec.Y,  0.1);
            Assert.AreEqual(vec.Z,convvec.Z,  0.1);


        }

    }
}

