using System;
using Xunit;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    /// <summary>
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
    public partial class Solution
    {
        public int RomanToInt(string s)
        {
            throw new NotImplementedException();
        }
    }

    public partial class SolutionTest
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void TestRomanToInt(string str, int expected)
        {
            var result = new Solution().RomanToInt(str);

            Assert.Equal<int>(result, expected);
        }
    }
}
