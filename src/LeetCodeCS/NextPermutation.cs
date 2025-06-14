using System;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int i = nums.Length - 2;

        while (i >= 0 && nums[i] >= nums[i+1])
        {
            i--;
        }

        if (i >= 0)
        {
            int j = nums.Length - 1;

            while (nums[j] <= nums[i])
            {
                j--;
            }

            int temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }

        int start = i + 1;
        int end = nums.Length - 1;
        while(start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;

            start++;
            end--;
        }
    }
}