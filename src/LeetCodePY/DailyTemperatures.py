from collections import deque
from typing import List
class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        if not temperatures:
            return []

        result = [0] * len(temperatures)

        stack = deque()

        for i in range(len(temperatures)):

            current_temp = temperatures[i]

            while stack and current_temp > temperatures[stack[-1]]:
                idx = stack.pop()
                result[idx] = i - idx
            stack.append(i)

        return result
