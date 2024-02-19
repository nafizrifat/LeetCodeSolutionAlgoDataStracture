using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionAlgoDataStracture
{
    class _023MergekSortedLists
    {
        public _023MergekSortedLists()
        {

            ListNode l1 = new ListNode(1,  new ListNode(4, new ListNode(5, null)));
            ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            ListNode l3 = new ListNode(2, new ListNode(6, null));


            var x = MergeKLists(new ListNode[] {l1, l2, l3});
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;

            if (lists.Length == 1)
                return lists[0];

            var currNode = lists[0];

            for (int i = 1; i < lists.Length; i++)
            {
                currNode = Merge(currNode, lists[i]);
            }

            return currNode;
        }

        private ListNode Merge(ListNode node1, ListNode node2)
        {
            ListNode returnValue = new ListNode(0);
            var curr = returnValue;

            while (node1 != null && node2 != null)
            {
                if (node1 != null && node2 != null)
                {
                    if (node1.val < node2.val)
                    {
                        curr.next = node1;
                        node1 = node1.next;
                    }
                    else
                    {
                        curr.next = node2;
                        node2 = node2.next;
                    }

                    curr = curr.next;
                }
            }

            if (node1 == null)
            {
                curr.next = node2;
            }

            if (node2 == null)
            {
                curr.next = node1;
            }

            return returnValue.next;
        }
    }
}
