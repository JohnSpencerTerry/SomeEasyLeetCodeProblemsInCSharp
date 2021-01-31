using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    public partial class Solution
    {
        public bool IsPalindromeNumber(int num)
        {
            var r = num.ToString().ToCharArray();

            Array.Reverse(r);

            return string.Join("", r) == num.ToString();
        }
    }

    public partial class SolutionTest
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(-101, false)]
        public void TestIsPalindromeNumber(int num, bool expected)
        {
            var result = new Solution().IsPalindromeNumber(num);

            Assert.Equal<bool>(result, expected);
        }
    }
}
