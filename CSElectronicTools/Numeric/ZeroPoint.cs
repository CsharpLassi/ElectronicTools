using System;

namespace CSElectronicTools
{
    public static class ZeroPoint
    {
        public static double HalfRangeByIteration(Func<double,double> function, int iteration,double point_a = 0,double point_b = 0)
        {
            //Startpoint
            do {
                point_a -=10;
                point_b +=10;
            } while (function(point_a)* function(point_b) >= 0);

            double xn = 0.0;

            //Methode
            for (int i = 0; i < iteration; i++)
            {
                xn = (point_b + point_a) / 2;
                double fa = function(point_a);
                double fb = function(point_b);
                double fx = function(xn);

                if (fa * fx < 0)
                {
                    point_b = xn;
                }
                else if (fb * fx < 0)
                {
                    point_a = xn;
                }
                else if (fx == 0)
                {
                    break;
                }
                else
                {
                    
                }



            }

            return xn;
        }
    }
}

