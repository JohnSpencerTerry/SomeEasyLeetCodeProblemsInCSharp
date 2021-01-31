using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    public partial class Solution
    {
        public int ReverseInteger(int x)
        {
            try
            {
                checked
                {
                    var charArray = System.Math.Abs(x).ToString().ToCharArray();
                    Array.Reverse(charArray);
                    if (x < 0)
                    {
                        return int.Parse(string.Join("", charArray)) * -1;
                    }
                    return int.Parse(string.Join("", charArray));

                }
            }
            catch (OverflowException ex)
            {
                return 0;
            }
        }
    }

    public partial class SolutionTest
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        public void TestReverseInteger(int num, int expected)
        {
            var result = new Solution().ReverseInteger(num);

            Assert.Equal<int>(result, expected);
        }
    }
}
