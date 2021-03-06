﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using bagOfClasses;

namespace bagOfClassesUnitTests
{
    public class PrimeFactorFinderTester
    {
        [Theory] 
        [InlineData(37, 37)]
        [InlineData(41, 123)]
        [InlineData(7, 196)]
        [InlineData(224069, 12547864)]
        public void shouldReturnLargestPrimeFactor(int desiredResult, int input)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Stack<long> factors = primeFactorFinder.GetPrimeFactors(input);
            long result = factors.Max();

            Assert.Equal(desiredResult, result);
        }
    }
}
