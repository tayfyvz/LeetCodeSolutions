from typing import List

class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        if not nums:
            return 0

        result = nums[0]

        sum = 0

        for i in range(len(nums)):
            sum = max(sum + nums[i], nums[i])

            result = max(result, sum)

        return result