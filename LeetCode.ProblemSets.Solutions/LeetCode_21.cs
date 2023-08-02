public class LeetCode_21
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }
        
        if (list2 == null)
        {
            return list1;
        }

        ListNode previous = null, head = list1;

        while (list1.next != null && list2.next != null)
        {
            if (list1.val < list2.val)
            {
                previous = list1;
                if (list1.next != null)
                {
                    list1 = list1.next;
                }
                else
                {
                    list1.next = list2;
                    break;
                }
                
            }
            else
            {
                var tempList2Next = list2.next;
                if (previous == null)
                {
                    head = list2;
                    previous = head;

                }
                else
                {
                    previous.next = list2;
                    previous = list2;
                }
                previous.next = list1;
                list2 = tempList2Next;
            }
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