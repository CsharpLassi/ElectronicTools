using NUnit.Framework;
using System;

namespace CSElectronicTools.Test
{
    [TestFixture()]
    public class NVectorTest
    {
        [Test()]
        public void LenghtTest()
        {

            NVector vec = new NVector(3);
            vec.SetData(1, 1, 1);

            Assert.AreEqual(Math.Sqrt(3),vec.Length(), 0.1);
        }

        [Test()]
        public void IndexTest()
        {

            NVector vec = new NVector(3);
            vec.SetData(1, 1, 1);

            vec[0] = 0;
            vec[1] = 10;
            vec[2] = 20;

            Assert.AreEqual(0, vec[0],0.1);
            Assert.AreEqual(10, vec[1],0.1);
            Assert.AreEqual(20, vec[2],0.1);
        }

        [Test()]
        public void IsLocalVectorTest()
        {
            NVector vec = new NVector(3);
            vec.SetData(1, 1, 1);


            Assert.IsTrue(vec.IsLocalVector);
        }
            
        [Test()]
        public void AddOperationTest()
        {
            NVector v1 = new NVector(3);
            v1.SetData(1, 2, 4);

            NVector v2 = new NVector(3);
            v2.SetData(1, 2, 3);

            NVector v3 = v1 + v2;

            Assert.AreEqual(2,v3[0], 0.1);
            Assert.AreEqual(4,v3[1], 0.1);
            Assert.AreEqual(7,v3[2], 0.1);
        }

        [Test()]
        public void SubOperationTest()
        {
            NVector v1 = new NVector(3);
            v1.SetData(1, 5, 4);

            NVector v2 = new NVector(3);
            v2.SetData(1, 2, 3);



            NVector v3 = v1 - v2;

            Assert.AreEqual(0,v3[0], 0.1);
            Assert.AreEqual(3,v3[1], 0.1);
            Assert.AreEqual(1,v3[2], 0.1);
        }

        [Test()]
        public void MulOperationTest()
        {
            NVector v1 = new NVector(3);
            v1.SetData(1, 2, 8);

            NVector v2 = new NVector(3);
            v2.SetData(3, 2, 1);

            NVector v3 = v1 * v2;
            NVector v4 = v1 * 2;

            Assert.AreEqual(3,v3[0], 0.1);
            Assert.AreEqual(4,v3[1], 0.1);
            Assert.AreEqual(8,v3[2], 0.1);

            Assert.AreEqual(2,v4[0], 0.1);
            Assert.AreEqual(4,v4[1], 0.1);
            Assert.AreEqual(16,v4[2], 0.1);
        }

        [Test()]
        public void DivOperationTest()
        {
            NVector v1 = new NVector(3);
            v1.SetData(1, 2, 8);

            NVector v2 = new NVector(3);
            v2.SetData(3, 2, 1);

            NVector v3 = v1 / v2;
            NVector v4 = v1 / 2;

            Assert.AreEqual(0.3,v3[0], 0.1);
            Assert.AreEqual(1,v3[1], 0.1);
            Assert.AreEqual(8,v3[2], 0.1);

            Assert.AreEqual(0.5,v4[0], 0.1);
            Assert.AreEqual(1,v4[1],  0.1);
            Assert.AreEqual(4,v4[2],  0.1);
        }

        [Test()]
        public void ScalarProductTest()
        {
            NVector vec = new NVector(3);
            vec.SetData(1, 1, 1);

            var product = NVector.ScalarProduct(vec, vec);

            Assert.AreEqual(1, 1, 0.1);
        }
    }
}

