using NUnit.Framework;
using System;

namespace CSElectronicTools.Test.Numeric
{
    [TestFixture()]
    public class ZeroPointTest
    {
        [Test()]
        public void HalfRangeByIteration()
        {
            Func<double,double> func = (x) => x - 2;
            double result = 2;
            double range = 0.1;

            Assert.AreEqual(result,ZeroPoint.HalfRangeByIteration(func,10),range);
        }
    }
}

