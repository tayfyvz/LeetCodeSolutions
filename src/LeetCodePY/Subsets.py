from typing import List
class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:

        result: List[List[int]] = []

        self.rec(result, nums, [], 0)

        return result

    def rec(self, result: List[List[int]], nums: List[int], subset: List[int], index: int):
        if index == len(nums):
            result.append(subset[:])
            return

        subset.append(nums[index])
        self.rec(result, nums, subset, index + 1)

        subset.pop()
        self.rec(result, nums, subset, index + 1)
