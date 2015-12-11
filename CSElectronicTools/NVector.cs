using System;
using System.Linq;

namespace CSElectronicTools
{
    public class NVector : IVector
    {
        public double[] Datas
        {
            get;
            private set;
        }
            
        public int N
        {
            get;
            private set;
        }

        public bool IsLocalVector
        {
            get{ return true; }
        }

        public NVector(int n)
        {
            Datas = new double[n];
            N = n;
        }

        public double this[int index]
        {
            get
            {
                return Datas[index];
            }
            set
            {
                Datas[index] = value;
            }
        }

        public void SetData(params double[] data)
        {
            int i = 0;
            foreach (var item in data)
            {
                Datas[i] = item;
                i++;
            }
        }

        public Distance SqrtLength()
        {
            return Datas.Sum(i => i * i);
        }

        public Distance Length()
        {
            return Math.Sqrt(SqrtLength());
        }

        public static ScalarValue ScalarProduct(NVector v1, NVector v2)
        {
            if (v1.N != v2.N)
            {
                throw new ArgumentException("N1 != N2");
            }

            double value = 0;

            for (int i = 0; i < v1.N; i++)
            {
                value = v1.Datas[i] * v2.Datas[i];
            }

            return value;

        }

        public static NVector operator + (NVector v1 , NVector v2)
        {
            if (v1.N != v2.N)
            {
                throw new ArgumentException("N1 != N2");
            }

            NVector vec = new NVector(v1.N);

            for (int i = 0; i < v1.N; i++)
            {
                vec.Datas[i] = v1.Datas[i] + v2.Datas[i];
            }


            return vec;
        }

        public static NVector operator - (NVector v1 , NVector v2)
        {
            if (v1.N != v2.N)
            {
                throw new ArgumentException("N1 != N2");
            }

            NVector vec = new NVector(v1.N);

            for (int i = 0; i < v1.N; i++)
            {
                vec.Datas[i] = v1.Datas[i] - v2.Datas[i];
            }


            return vec;
        }

        public static NVector operator * (NVector v1 , NVector v2)
        {
            if (v1.N != v2.N)
            {
                throw new ArgumentException("N1 != N2");
            }

            NVector vec = new NVector(v1.N);

            for (int i = 0; i < v1.N; i++)
            {
                vec.Datas[i] = v1.Datas[i] * v2.Datas[i];
            }


            return vec;
        }

        public static NVector operator * (NVector v1 , ScalarValue sv)
        {
            NVector vec = new NVector(v1.N);

            for (int i = 0; i < v1.N; i++)
            {
                vec.Datas[i] = v1.Datas[i] * sv;
            }


            return vec;
        }

        public static NVector operator / (NVector v1 , NVector v2)
        {
            if (v1.N != v2.N)
            {
                throw new ArgumentException("N1 != N2");
            }

            NVector vec = new NVector(v1.N);

            for (int i = 0; i < v1.N; i++)
            {
                vec.Datas[i] = v1.Datas[i] / v2.Datas[i];
            }


            return vec;
        }

        public static NVector operator / (NVector v1 , ScalarValue sv)
        {
            NVector vec = new NVector(v1.N);

            for (int i = 0; i < v1.N; i++)
            {
                vec.Datas[i] = v1.Datas[i] / sv;
            }


            return vec;
        }


    }
}

