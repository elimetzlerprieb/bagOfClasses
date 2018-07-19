using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using bagOfClasses;

namespace bagOfClassesUnitTests
{
    public class PrimeFinderTester
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(7)]
        [InlineData(193)]
        [InlineData(269)]
        public void isPrimeShouldReturnTrueForPrimes(int value)
        {
            PrimeFinder primeFinder = new bagOfClasses.PrimeFinder();
            Assert.True(primeFinder.IsPrime(value));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(21)]
        [InlineData(33)]
        [InlineData(49)]
        [InlineData(100)]
        [InlineData(174)]
        public void isPrimeShouldReturnFalseForNonPrimes(int value)
        {
            PrimeFinder primeFinder = new bagOfClasses.PrimeFinder();
            Assert.False(primeFinder.IsPrime(value));
        }
    }
}
