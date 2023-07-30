namespace LeetCode.Problem141;

public class LeetCode_142
{
    // Fast-Slow Pointer with counter.
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return null;
        }
        
        var fast = head;
        var slow = head;
        var loopFlag = false;

        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (fast == slow)
            {
                loopFlag = true;
                break;
            }
        }

        if (!loopFlag)
        {
            return null;
        }

        var roundCheck = head;
    
        while (roundCheck != slow)
        {
            roundCheck = roundCheck.next;
            slow = slow.next;
        }

        return roundCheck;

    }
}