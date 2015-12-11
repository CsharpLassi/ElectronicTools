using System;

namespace CSElectronicTools.Dummy
{
    class MainClass
    { 
       
        public static void Main(string[] args)
        {
            NVector v1 = new NVector(3);
            v1.SetData(1, 2, 4);

            NVector v2 = new NVector(3);
            v2.SetData(1, 2, 3);

            NVector v3 = v1 + v2;
        }
    }
}
