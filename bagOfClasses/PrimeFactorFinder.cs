﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagOfClasses
{
    public class PrimeFactorFinder
    {
        private Stack<int> primes;

        public bool findFactors(int A)
        {


            return true;
        }

        public bool isPrime(int A)
        {
            if ((A == 2) || (A == 1))
                return true;
            else if (( A % 2 == 0 ) || (A % 5 == 0))
            {
                return false;
            }
            for(int i = 3; i < A / 2; i += 2)
            {
                if (A % i == 0)
                {
                    return false;
                }
            }

        return true;
        }


        

    }
}
