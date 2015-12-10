using NUnit.Framework;
using System;

namespace CSElectronicTools.Test
{
    [TestFixture()]
    public class DistanceTest
    {
        [Test()]
        public void SetOkTest()
        {
            try
            {
                Distance d = new Distance(5);

                d = 0;
                d = 10;


            }
            catch (Exception ex)
            {
                Assert.Fail();
            }

            Assert.Pass();
        }

        [Test()]
        public void SetFalseTest()
        {


            try
            {
                Distance d = new Distance(-5);
            }
            catch (Exception ex)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}

