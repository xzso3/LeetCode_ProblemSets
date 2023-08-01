public class LeetCode_2
{
    public bool carryFlag = false;
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var a = l1;
        var b = l2;
        
        while (true)
        {
            a.val += b.val;
            if (carryFlag)
            {
                a.val++;
            }

            if (a.val > 9)
            {
                a.val -= 10;
                carryFlag = true;
            }
            else
            {
                carryFlag = false;
            }

            
            if (a.next != null && b.next != null)
            {
                a = a.next;
                b = b.next;
            }
            else
            {
                break;
            }
            
        }

        if (a.next == null && b.next == null)
        {
            if (carryFlag)
            {
                a.next = new ListNode(1, null);
            }
            
        }
        else if (a.next != null && b.next == null)
        {
            ProcessRemainList(a.next);
        }
        else
        {
            a.next = b.next;
            ProcessRemainList(a.next);
        }
        
        
        return l1;
    }

    public void ProcessRemainList(ListNode a)
    {
        while (true)
        {
            if (carryFlag)
            {
                a.val += 1;
            }
                
            if (a.val > 9)
            {
                a.val = 0;
                carryFlag = true;
            }
            else
            {
                carryFlag = false;
                break;
            }

            if (a.next != null)
            {
                a = a.next;
            }
            else
            {
                break;
            }
            
        }

        if (carryFlag)
        {
            a.next = new ListNode(1, null);
        }
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