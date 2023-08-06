public class LeetCode_24
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null) return head;
        var front = head;
        var back = head.next;
        var next = back.next;
        back.next = front;
        front.next = SwapPairs(next);
        return back;
    }
    
     public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null) 
         {
            this.val = val;
            this.next = next; 
         }
     }
}