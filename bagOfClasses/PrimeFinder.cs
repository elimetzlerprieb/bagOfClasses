using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    public class PrimeFinder
    {
        public bool IsPrime(int A)
        {
            if ((A == 2) || (A == 1))
                return true;
            else if ((A % 2 == 0) || (A % 5 == 0))
            {
                return false;
            }
            for (int i = 3; i <= Math.Ceiling(Math.Sqrt(A)); i += 2)
            {
                if (A % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int[] GeneratePrimes(int max)
        {
            List<int> set = new List<int>();
            
            for (int i = 0; i < max -1; i++)
            {
                set.Add(i);
            }

            for (int a = 2; a <= Math.Ceiling(Math.Sqrt(max)); a++)
            {
                set.RemoveAll(x => (x % a == 0) && (x != a));
            }

            return set.ToArray();
        }






        public bool IsPrime(long A)
        {
            int val = (int)A;
            return IsPrime(val);
        }
    }
}
