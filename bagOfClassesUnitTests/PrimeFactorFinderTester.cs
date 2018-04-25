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
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsOddTestForOdds(int value)
        {
            Assert.True(IsOdd(value));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void IsOddTestForEvens(int value)
        {
            Assert.False(IsOdd(value));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(7)]
        [InlineData(193)]
        [InlineData(269)]
        public void primeFactorFinderIsPrimeTestPrimes(int value)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Assert.True(primeFactorFinder.isPrime(value));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(21)]
        [InlineData(33)]
        [InlineData(100)]
        [InlineData(174)]
        public void primeFactorFinderIsPrimeTestNotPrimes(int value)
        {
            PrimeFactorFinder primeFactorFinder = new PrimeFactorFinder();
            Assert.False(primeFactorFinder.isPrime(value));
        }





        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        int Add(int x, int y)
        {
            return x + y; 
        }

    }
}
