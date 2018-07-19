using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using bagOfClasses; 

namespace bagOfClassesUnitTests
{
    public class ParenValidatorTester
    {
        [Theory]
        [InlineData("()()()")]
        [InlineData("(())()(((())))")]
        [InlineData("()(((()))())")]
        public void returnTrueForValidParentheses(string input)
        {
            bool shouldBeTrue = ParenValidator.IsValid(input);
            Assert.True(shouldBeTrue);
        }

        [Theory]
        [InlineData(")()()")]
        [InlineData("(()))()(((())))")]
        [InlineData("()(((()))()))")]
        public void returnFalseForInvalidParentheses(string input)
        {
            bool shouldBeFalse = ParenValidator.IsValid(input);
            Assert.False(shouldBeFalse);
        }






    }
}
