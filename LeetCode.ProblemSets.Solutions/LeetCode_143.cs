namespace LeetCode.Problem141;

public class LeetCode_143
{
    public void ReorderList(ListNode head)
    {
        // When it is a single element linked list.
        if (head.next == null)
        {
            return;
        }

        // When the linked list contains two elements.
        if (head.next.next == null)
        {
            return;
        }
        
        // 1. Get to Middle node by fast-slow pointer.
        var middle = GetMiddleNode(head);
        // 2. Reverse the latter half of linked list.
        var reversedLatterHalfList = ReverseLinkedList(middle);
        // 3. cross-merge the linked list.
        MergeLinkedList(head, reversedLatterHalfList);
    }

    public ListNode GetMiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    public ListNode ReverseLinkedList(ListNode head)
    {
        ListNode tmpPrevNext = null;
        var prev = head;
        var sub = head.next;
        while (sub != null)
        {
            prev.next = tmpPrevNext;
            tmpPrevNext = prev;
            prev = sub;
            sub = sub.next;
        }

        prev.next = tmpPrevNext;
        return prev;
    }

    public void MergeLinkedList(ListNode head, ListNode insertion)
    {
        var baseNode = head;
        while (baseNode != null && insertion != null)
        {
            var tmpBaseNextNode = baseNode.next;
            var tmpInsertionNextNode = insertion.next;
            baseNode.next = insertion;
            insertion.next = tmpBaseNextNode;
            insertion = tmpInsertionNextNode;
            baseNode = tmpBaseNextNode;
        }
    }
}