using System;
using Xunit;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    public partial class Solution
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        public int[] TwoSums(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }

    public partial class SolutionTest
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TestTwoSums(int[] nums, int target, int[] expected)
        {
            var result = new Solution().TwoSums(nums, target);

            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal<int>(result, expected);
        }
    }
}
