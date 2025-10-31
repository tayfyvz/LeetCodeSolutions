from typing import Optional
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
class Solution:
    def isBalanced(self, root: Optional[TreeNode]) -> bool:

        if not root:
            return True

        return self.CheckHeight(root) != -1

    def CheckHeight(self, root: Optional[TreeNode]) -> int:

        if not root:
            return 0

        left = self.CheckHeight(root.left)
        right = self.CheckHeight(root.right)

        if abs(left - right) > 1 or left == -1 or right == -1:
            return -1

        return max(left, right) + 1