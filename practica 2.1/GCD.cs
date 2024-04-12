using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2._1
{
    public class GCD
    {
        public int FindGCD(int m, int n)
        {
            while (n != 0)
            {
                int temp = n;
                n = m % n;
                m = temp;
            }
            return m;
        }

        public int FindGCD(int m, int n, int k)
        {
            return FindGCD(FindGCD(m, n), k);
        }

        public int FindGCD(int m, int n, int k, int l)
        {
            return FindGCD(FindGCD(m, n), FindGCD(k, l));
        }

        public int FindGCD(int m, int n, int k, int l, int o)
        {
            return FindGCD(FindGCD(m, n, k, l), o);
        }
    }
}
