using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    public partial class Solution
    {
        public bool IsValidParentheses(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    default:
                        {
                            if (stack.Count == 0 || stack.Pop() != c) return false;
                        }
                        break;
                }
            }
            return stack.Count == 0;
        }
    }




    public partial class SolutionTest
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("(])]", false)]
        [InlineData("{[]}", true)]
        public void IsValidParentheses(string s, bool expected)
        {
            var result = new Solution().IsValidParentheses(s);

            Assert.Equal(result, expected);
        }
    }
}
