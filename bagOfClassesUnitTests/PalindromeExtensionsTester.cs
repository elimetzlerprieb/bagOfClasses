using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using bagOfClasses;

namespace bagOfClassesUnitTests
{
    public class PalindromeExtensionsTester
    {
        [Theory]
        [InlineData("123321")]
        [InlineData("ABCCBA")]
        [InlineData("ABCDCBA")]
        public void ShouldReturnTrueIfPalindrome(string input)
        {
            Assert.True(input.isPalindrome());
        }

        [Theory]
        [InlineData(123321)]
        [InlineData(9003009)]
        [InlineData(90011009)]
        [InlineData(12344321)]
        public void ShouldReturnTrueIfPalindrome(int input)
        {
            Assert.True(input.isPalindrome());
        }

    }
}
