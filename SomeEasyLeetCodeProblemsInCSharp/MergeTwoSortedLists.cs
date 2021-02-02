using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static SomeEasyLeetCodeProblemsInCSharp.Soution;

namespace SomeEasyLeetCodeProblemsInCSharp
{
    public partial class Soution      
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            throw new NotImplementedException();
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }

    public partial class SolutionTest
    {
        public void TestMergeTwoLists(ListNode l1, ListNode l2, ListNode expected)
        {

        }
    }


}
