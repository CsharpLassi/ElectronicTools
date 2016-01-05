using System;

namespace CSElectronicTools.Signal
{
    public static class Correlation
    {
        public static ScalarValue[] CrossCorrelation(ScalarValue[] sig1,ScalarValue[] sig2)
        {
            int lowdim = sig1.Length <= sig2.Length ? sig1.Length : sig2.Length;

            ScalarValue[] result = new ScalarValue[lowdim * 2 - 1];

            result[lowdim -1] = CrossCorrelation(sig1, sig2, 0);

            for (int i = 1; i < lowdim; i++)
            {
                result[lowdim -1 + i] = CrossCorrelation(sig1, sig2, i);
                result[lowdim -1 - i] = CrossCorrelation(sig1, sig2, -i);
            }

            return result;
        }

        public static ScalarValue CrossCorrelation(ScalarValue[] sig1,ScalarValue[] sig2, ScalarValue dt)
        {
            int lowdim = sig1.Length < sig2.Length ? sig1.Length : sig2.Length;

            ScalarValue result = 0;

            int i1 = 0;
            int i2 = 0;

            if (dt > 0)
                i2 = dt;
            else if (dt < 0)
                i1 = -dt;

            while (true)
            {
                if (i1 >= sig1.Length || i2 >= sig1.Length)
                    break;

                result += sig1[i1] * sig2[i2];

                i1++;
                i2++;
            }
                

            return result;
        }

        public static ScalarValue[] AutoCorrelation(ScalarValue[] sig1)
        {
            return CrossCorrelation(sig1, sig1);
        }

        public static ScalarValue AutoCorrelation(ScalarValue[] sig1,ScalarValue[] sig2, ScalarValue dt)
        {
            return CrossCorrelation(sig1, sig1,dt);
        }
    }
}

