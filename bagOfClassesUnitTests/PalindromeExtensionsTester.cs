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
        public void ShouldReturnTrueIfPalindromeString(string input)
        {
            Assert.True(input.IsPalindrome());
        }

        [Theory]
        [InlineData(123321)]
        [InlineData(9003009)]
        [InlineData(90011009)]
        [InlineData(12344321)]
        public void ShouldReturnTrueIfPalindromeInt(int input)
        {
            Assert.True(input.IsPalindrome());
        }

    }
}
