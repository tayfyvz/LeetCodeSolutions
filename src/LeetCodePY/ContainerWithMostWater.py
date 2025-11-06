from typing import List
class Solution:
    def maxArea(self, height: List[int]) -> int:

        if not height:
            return 0

        left = 0
        right = len(height) - 1

        max_vol = 0

        while left < right:

            vol = min(height[left], height[right]) * (right - left)
            if vol > max_vol:
                max_vol = vol

            if height[right] < height[left]:
                right -= 1
            else:
                left += 1

        return max_vol