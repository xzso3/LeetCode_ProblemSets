public class LeetCode_83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var iterator = head;
        ListNode prev = null;

        while (iterator != null)
        {
            if (prev == null)
            {
                prev = iterator;
                iterator = iterator.next;
                continue;
            }

            if (prev.val == iterator.val)
            {
                prev.next = iterator.next;
            }
            else
            {
                prev = iterator;
            }
            
            iterator = iterator.next;
        }
        return head;
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