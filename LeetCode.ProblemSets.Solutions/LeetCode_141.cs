using System.Runtime.InteropServices;

namespace LeetCode.Problem141
{
    public class LeetCode_141
    {
        public bool HasCycle(ListNode head)
        {
            var fast = head;
            var slow = head;
            
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    
}

