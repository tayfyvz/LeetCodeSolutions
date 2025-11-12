from typing import Optional
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        if not head:
            return
        if n == 0:
            return head

        result = ListNode(0, head)

        pointer = result

        for i in range(n):
            head = head.next

        while head:
            head = head.next
            pointer = pointer.next

        pointer.next = pointer.next.next

        return result.next