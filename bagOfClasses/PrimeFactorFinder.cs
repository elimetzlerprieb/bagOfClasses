using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    public class PrimeFactorFinder
    {
        private Stack<long> factors = new Stack<long>();

        PrimeFinder primeFinder = new PrimeFinder();

        public Stack<long> GetPrimeFactors(long A)
        {
            FindFactors(A);
            return factors;
        }

        public long GetLargestPrimeFactor(long A)
        {
            FindFactors(A);
            return factors.Max();
        }

        private bool FindFactors(long A)
        {
            // base case : A is prime therefore A is a factor 

            if(primeFinder.IsPrime(A) == true)
            {
                factors.Push(A);
                return true;
            }
            else // non base case : if A is not a prime, we need to find the next prime that can divide it
            {
                int i = 2;

                while ( i < (A / 2))
                {
                    // Naive implementation - perhaps replace with getNextPrime(); ?
                    if(primeFinder.IsPrime(i) == true)
                    {
                        if (A % i == 0)
                        {
                            A = A / i;

                            factors.Push(i);

                            bool rv = FindFactors(A);

                            if (rv == true)
                            {
                                return true;
                            }
                            else
                            {
                                factors.Pop();
                            }
                        }
                    }
                    
                    i++;
                }
            }
            return false;
        }
    }
}
