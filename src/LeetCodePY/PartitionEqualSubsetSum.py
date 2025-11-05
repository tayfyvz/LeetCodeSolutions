from typing import List
class Solution:
    def canPartition(self, nums: List[int]) -> bool:

        totalSum = sum(nums)

        if totalSum % 2 == 1:
            return False

        target = (totalSum // 2)

        dp = [False] * (target + 1)
        dp[0] = True

        for num in nums:
            for i in range(target, num - 1, -1):
                if dp[i - num]:
                    dp[i] = True
                if dp[-1]:
                    return True
        return False