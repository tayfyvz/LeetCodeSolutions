
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

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if(lists.Length == 0)
        {
            return null;
        }

        return Devide(lists, 0, lists.Length - 1);
    }

    public ListNode Devide(ListNode[] list, int start, int end)
    {
        if(start < end)
        {
            int mid = (start + end) / 2;
            ListNode left = Devide(list, start, mid);
            ListNode right = Devide(list, mid + 1, end);
            return SortTwoList(left, right);
        }

        return list[start];
    }

    public ListNode SortTwoList(ListNode node1, ListNode node2)
    {
        if(node1 == null)
        {
            return node2;
        }

        if (node2 == null)
        {
            return node1;
        }

        if (node1.val <= node2.val)
        {
            node1.next = SortTwoList(node1.next, node2);
            return node1;
        }

        else
        {
            node2.next = SortTwoList(node1, node2.next);
            return node2;
        }
    }
}