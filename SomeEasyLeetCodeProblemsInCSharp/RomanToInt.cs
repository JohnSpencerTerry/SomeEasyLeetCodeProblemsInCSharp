using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    /// <summary>
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
    public partial class Solution
    {
        /*
         Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000

        For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

        Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.

        Given a roman numeral, convert it to an integer.
         */

        public int RomanToInt(string s)
        {
            // order matters here
            var romanToIntMappings = new RomanToIntMapping[] {
                new RomanToIntMapping("IV", 4),
                new RomanToIntMapping("IX", 9),
                new RomanToIntMapping("XL", 40),
                new RomanToIntMapping("XC", 90),
                new RomanToIntMapping("CD", 400),
                new RomanToIntMapping("CM", 900),

                new RomanToIntMapping("I", 1),
                new RomanToIntMapping("V", 5),
                new RomanToIntMapping("X", 10),
                new RomanToIntMapping("L", 50),
                new RomanToIntMapping("C", 100),
                new RomanToIntMapping("D", 500),
                new RomanToIntMapping("M", 1000),
            };


            int total = 0;

            for (int i = 0; i < romanToIntMappings.Length; i++)
            {
                total += Regex.Matches(s, romanToIntMappings[i].RomanValue).Count * romanToIntMappings[i].IntegerValue;
                s = s.Replace(romanToIntMappings[i].RomanValue, "");
            }


            return total;
        }

        private struct RomanToIntMapping
        {
            public RomanToIntMapping(string romanValue, int integerValue)
            {
                RomanValue = romanValue;
                IntegerValue = integerValue;
            }
            public string RomanValue;
            public int IntegerValue;
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
