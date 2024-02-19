using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionAlgoDataStracture
{
    class _019RemoveNthNode
    {
        public _019RemoveNthNode()
        {
            ListNode aNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));

            RemoveNthFromEnd(aNode, 2);
        }

        int maxNode = 0;
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            return Process(head, n, 0);
        }

        private ListNode Process(ListNode node, int n, int position)
        {

            if (node == null)
            {
                maxNode = position;
            }
            else
            {
                 node.next = Process(node.next, n, position + 1);
            }

            if (position + n == maxNode)
            {
                node = node.next;
            }

            return node;
        }
    }
}
 //   /**
 //* Definition for singly-linked list.
 //* public class ListNode {
 //*     public int val;
 //*     public ListNode next;
 //*     public ListNode(int val=0, ListNode next=null) {
 //*         this.val = val;
 //*         this.next = next;
 //*     }
 //* }
 //*/
    

