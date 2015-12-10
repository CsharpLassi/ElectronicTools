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

        [Test()]
        public void ToCylinderVectorTest()
        {
            Vector vec = new Vector(1,1,1);
            var convvec = vec.ToCylinderVector();

            Assert.AreEqual(convvec.Rho, Math.Sqrt(2), 0.1);
            Assert.AreEqual(convvec.Phi, Math.PI/4, 0.1);
            Assert.AreEqual(convvec.Z, vec.Z, 0.1);

            vec = new Vector(1,-1,1);
            convvec = vec.ToCylinderVector();

            Assert.AreEqual(convvec.Rho, Math.Sqrt(2), 0.1);
            Assert.AreEqual(convvec.Phi, -Math.PI/4, 0.1);
            Assert.AreEqual(convvec.Z, vec.Z, 0.1);
        }

        [Test()]
        public void ToPolarVectorTest()
        {
            Vector vec = new Vector(1,1,1);
            var convvec = vec.ToPolarVector();

            Assert.AreEqual(convvec.R, Math.Sqrt(3), 0.1);
            Assert.AreEqual(convvec.Phi, Math.PI/4, 0.1);
            Assert.AreEqual(convvec.Theta, Math.PI/4, 0.1);

           
        }
    }
}

