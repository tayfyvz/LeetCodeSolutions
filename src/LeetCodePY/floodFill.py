from collections import deque
from typing import List

class Solution:
    def floodFill(self, image: List[List[int]], sr: int, sc: int, color: int) -> List[List[int]]:

        if not image:
            return []

        if image[sr][sc] == color:
            return image

        oldColor = image[sr][sc]

        queue = deque()
        queue.append((sr, sc))
        
        while queue:
            x, y = queue.popleft()
            image[x][y] = color

            if x + 1 < len(image) and image[x + 1][y] == oldColor:
                queue.append((x+1, y))
            if x - 1 >= 0 and image[x - 1][y] == oldColor:
                queue.append((x - 1, y))
            if y + 1 < len(image[0]) and image[x][y + 1] == oldColor:
                queue.append((x, y+1))
            if y - 1 >= 0 and image[x][y - 1] == oldColor:
                queue.append((x, y-1))

        return image