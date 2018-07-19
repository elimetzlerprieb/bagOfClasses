using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using bagOfClasses;

namespace bagOfClassesUnitTests
{
    public class StringReverseTester
    {
        [Theory]
        [InlineData("ABCDEF", "FEDCBA")]
        [InlineData("XYZ123!", "!321ZYX")]
        [InlineData("Artichoke", "ekohcitrA")]

        public void ReverseString_InPlace(string inputString, string reversedString)
        {
            string generatedString = StringReverse.InPlace(inputString);
            Assert.Equal(reversedString, generatedString);
        }

        [Theory]
        [InlineData("ABCDEF", "FEDCBA")]
        [InlineData("XYZ123!", "!321ZYX")]
        [InlineData("Artichoke", "ekohcitrA")]

        public void ReverseString_WithBUffer(string inputString, string reversedString)
        {
            string generatedString = StringReverse.WithBuffer(inputString);
            Assert.Equal(reversedString, generatedString);
        }

    }
}
