from collections import deque
from typing import List

class Solution:
    def pacificAtlantic(self, heights: List[List[int]]) -> List[List[int]]:
        if not heights:
            return [[]]

        direction_list = [(1, 0), (-1, 0), (0, 1), (0, -1)]
        result: List[List[int]] = []
        safe = set()
        row = len(heights)
        column = len(heights[0])

        for i in range(row):
            for j in range(column):
                stack = deque()
                visited = set()
                pacific = False
                atlantic = False

                stack.append((i, j))

                while stack:
                    (r, c) = stack.pop()

                    if (r, c) in safe:
                        result.append([i, j])
                        break

                    visited.add((r, c))

                    if r == 0 or c == 0:
                        pacific = True
                    if r == row - 1 or c == column - 1:
                        atlantic = True

                    if atlantic and pacific:
                        result.append([i, j])
                        safe.add((i, j))
                        break
                    for x, y in direction_list:
                        if 0 <= r + x < row and 0 <= c + y < column and (r + x, c + y) not in visited and heights[r][c] >= heights[r+x][c+y]:
                            stack.append((r+x, c+y))

        return result