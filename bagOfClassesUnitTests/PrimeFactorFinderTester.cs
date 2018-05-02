using System;
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
        [Fact]
        public void AddTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(7)]
        [InlineData(193)]
        [InlineData(269)]
        public void isPrimeV0ShouldReturnTrueForPrimes(int value)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Assert.True(primeFactorFinder.isPrimeV0(value));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(21)]
        [InlineData(33)]
        [InlineData(49)]
        [InlineData(100)]
        [InlineData(174)]
        public void isPrimeV0ShouldReturnFalseForNonPrimes(int value)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Assert.False(primeFactorFinder.isPrimeV0(value));
        }

        [Theory]
        [InlineData(37, 37)]
        [InlineData(41, 123)]
        [InlineData(7, 196)]
        [InlineData(224069, 12547864)]
        public void shouldReturnLargestPrimeFactor(int desiredResult, int input)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            bool rv = primeFactorFinder.findFactors(input);
            int result = primeFactorFinder.largestPrimeFactor();
            Assert.Equal(desiredResult, result);
        }

        
        //isPrimeV2 testing 
        /*
        [Theory]
        [InlineData(4)]
        [InlineData(21)]
        [InlineData(33)]
        [InlineData(100)]
        [InlineData(174)]
        public void isPrimeV1ShouldReturnFalseForNonPrimes(int value)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Assert.False(primeFactorFinder.isPrimeV1(value));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(7)]
        [InlineData(193)]
        [InlineData(269)]
        public void isPrimeV1ShouldReturnTrueForPrimes(int value)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Assert.True(primeFactorFinder.isPrimeV1(value));
        }
        */

        int Add(int x, int y)
        {
            return x + y; 
        }

    }
}
