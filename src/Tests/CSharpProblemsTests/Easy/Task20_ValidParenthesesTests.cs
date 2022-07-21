using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task20_ValidParenthesesTests
    {
        [Fact]
        public void IsValid1()
        {
            var s = "()";

            var result = new Task20_ValidParentheses()
                                .IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void IsValid2()
        {
            var s = "()[]{}";

            var result = new Task20_ValidParentheses()
                                .IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void IsValid3()
        {
            var s = "(";

            var result = new Task20_ValidParentheses()
                                .IsValid(s);

            Assert.False(result);
        }

        [Fact]
        public void IsValid4()
        {
            var s = "([)]";

            var result = new Task20_ValidParentheses()
                                .IsValid(s);

            Assert.False(result);
        }

        [Fact]
        public void IsValid5()
        {
            var s = "{[]}";

            var result = new Task20_ValidParentheses()
                                .IsValid(s);

            Assert.True(result);
        }

    }
}
