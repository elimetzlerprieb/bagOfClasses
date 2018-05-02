using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    public class PrimeFactorFinder
    {

        public PrimeFactorFinder()
        {
            //Stack<int> primeFactors = new Stack<int>();
        }

        private Stack<int> primeFactors = new Stack<int>();


        
        public int largestPrimeFactor()
        {
            return primeFactors.Max();
        }

        public bool findFactors(int A)
        {
            // base case : A is prime therefore A is a factor 

            if (isPrimeV0(A) == true)
            {
                primeFactors.Push(A);
                return true;
            }
            else // non base case : if A is not a prime, we need to find the next prime that can divide it
            {
                int i = 2;

                while ( i < (A / 2))
                {
                    // Naive implementation - perhaps replace with getNextPrime(); ?
                    if (isPrimeV0(i) == true)
                    {
                        if (A % i == 0)
                        {
                            A = A / i;

                            primeFactors.Push(i);

                            bool rv = findFactors(A);

                            if (rv == true)
                            {
                                return true;
                            }
                            else
                            {
                                primeFactors.Pop();
                            }
                        }
                    }
                    
                    i++;
                }
            }
            return false;
        }

        public bool isPrimeV0(int A)
        {
            if ((A == 2) || (A == 1))
                return true;
            else if (( A % 2 == 0 ) || (A % 5 == 0))
            {
                return false;
            }
            for(int i = 3; i <=  Math.Ceiling(Math.Sqrt(A)); i += 2)
            {
                if (A % i == 0)
                {
                    return false;
                }
            }

        return true;
        }

        public bool isPrimeV1(int A)
        {      
            return true; 
        }


        

    }
}
