using NUnit.Framework;
using System;
using CSElectronicTools.Signal;

namespace CSElectronicTools.Test.Signal
{
    [TestFixture()]
    public class CorrelationTest
    {
        [Test()]
        public void CrossCorrelation1DTest_1()
        {
            ScalarValue[] value = { 0, 1, 0 };

            Assert.AreEqual(1, Correlation.CrossCorrelation(value, value, 0), 0.1);
            Assert.AreEqual(0, Correlation.CrossCorrelation(value, value, 1), 0.1);
            Assert.AreEqual(0, Correlation.CrossCorrelation(value, value, -1), 0.1);


            var arr = Correlation.CrossCorrelation(value, value);

            Assert.AreEqual(5, arr.Length);

            Assert.AreEqual(0, arr[0], 0.1);
            Assert.AreEqual(0, arr[1], 0.1);
            Assert.AreEqual(1, arr[2], 0.1);
            Assert.AreEqual(0, arr[3], 0.1);
            Assert.AreEqual(0, arr[4], 0.1);

        }

        [Test()]
        public void CrossCorrelation1DTest_2()
        {
            ScalarValue[] value = { 0, 1, 1 };

            Assert.AreEqual(2, Correlation.CrossCorrelation(value, value, 0), 0.1);
            Assert.AreEqual(1, Correlation.CrossCorrelation(value, value, 1), 0.1);
            Assert.AreEqual(1, Correlation.CrossCorrelation(value, value, -1), 0.1);


            var arr = Correlation.CrossCorrelation(value, value);

            Assert.AreEqual(5, arr.Length);

            Assert.AreEqual(0, arr[0], 0.1);
            Assert.AreEqual(1, arr[1], 0.1);
            Assert.AreEqual(2, arr[2], 0.1);
            Assert.AreEqual(1, arr[3], 0.1);
            Assert.AreEqual(0, arr[4], 0.1);

        }
    }
}

