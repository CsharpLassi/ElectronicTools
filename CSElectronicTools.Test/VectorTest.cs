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

            Assert.AreEqual(Math.Sqrt(3),convvec.R, 0.1);
            Assert.AreEqual(Math.PI/4,convvec.Phi, 0.1);
            Assert.AreEqual(0.955, convvec.Theta, 0.1);
        }

        [Test()]
        public void AddOperationTest()
        {
            Vector v1 = new Vector(1, 2, 4);
            Vector v2 = new Vector(1, 2, 3);

            Vector v3 = v1 + v2;

            Assert.AreEqual(v3.X, 2 , 0.1);
            Assert.AreEqual(v3.Y, 4, 0.1);
            Assert.AreEqual(v3.Z, 7, 0.1);
        }

        [Test()]
        public void SubOperationTest()
        {
            Vector v1 = new Vector(1, 5, 4);
            Vector v2 = new Vector(1, 2, 3);

            Vector v3 = v1 - v2;

            Assert.AreEqual(v3.X, 0, 0.1);
            Assert.AreEqual(v3.Y, 3, 0.1);
            Assert.AreEqual(v3.Z, 1, 0.1);
        }

        [Test()]
        public void MulOperationTest()
        {
            Vector v1 = new Vector(1, 2, 8);
            Vector v2 = new Vector(3, 2, 1);

            Vector v3 = v1 * v2;
            Vector v4 = v1 * 2;

            Assert.AreEqual(v3.X, 3, 0.1);
            Assert.AreEqual(v3.Y, 4, 0.1);
            Assert.AreEqual(v3.Z, 8, 0.1);

            Assert.AreEqual(v4.X, 2, 0.1);
            Assert.AreEqual(v4.Y, 4, 0.1);
            Assert.AreEqual(v4.Z, 16, 0.1);
        }

        [Test()]
        public void DivOperationTest()
        {
            Vector v1 = new Vector(1, 2, 8);
            Vector v2 = new Vector(3, 2, 1);

            Vector v3 = v1 / v2;
            Vector v4 = v1 / 2;

            Assert.AreEqual(v3.X, 0.3, 0.1);
            Assert.AreEqual(v3.Y, 1, 0.1);
            Assert.AreEqual(v3.Z, 8, 0.1);

            Assert.AreEqual(v4.X, 0.5, 0.1);
            Assert.AreEqual(v4.Y, 1, 0.1);
            Assert.AreEqual(v4.Z, 4, 0.1);
        }
    }
}

