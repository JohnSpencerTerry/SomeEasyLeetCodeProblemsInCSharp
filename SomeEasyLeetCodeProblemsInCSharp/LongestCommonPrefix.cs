using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    public partial class Solution {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            var minLength = strs.Min(x => x.Length);
            string shortestString = strs.Where(x => x.Length == minLength).First();

            StringBuilder prefixString = new StringBuilder();

            for (int i = 0; i < shortestString.Length; i++)
            {
                var prefixChar = shortestString[i];

                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != prefixChar) return prefixString.ToString();
                }

                prefixString.Append(prefixChar);
            }

            return prefixString.ToString();
        }
    }

    public partial class SolutionTest
    {
        [Theory]
        [InlineData(new string[] {}, "")]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        public void TestLongestCommonPrefix(string[] strs, string expected)
        {
            var result = new Solution().LongestCommonPrefix(strs);

            Assert.NotNull(result);
            Assert.Equal(result, expected);
        }
    }
}
