from collections import deque
class Solution:
    def uniquePaths(self, m: int, n: int) -> int:

        stack = deque()
        stack.append((0, 0))
        result = 0
        while stack:
            (i, j) = stack.pop()

            if i == m - 1 and j == n - 1:
                result += 1

            if i + 1 < m:
                stack.append((i + 1, j))
            if j + 1 < n:
                stack.append((i, j + 1))

        return result
