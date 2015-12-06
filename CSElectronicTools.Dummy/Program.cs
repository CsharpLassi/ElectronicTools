using System;

namespace CSElectronicTools.Dummy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Func<double,double> func = (x) => x - 2;
            double result = 2;
            double range = 0.1;

            double value = ZeroPoint.HalfRangeByIteration(func,10);
        }
    }
}
