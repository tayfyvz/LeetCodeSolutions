using System;

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        
        int withFirst = Check(nums, 0, nums.Length - 2);
        int withoutFirst = Check(nums, 1, nums.Length - 1);

        return Math.Max(withFirst, withoutFirst);
    }

    private int Check(int[] arr, int startingIndex, int endingIndex)
    {
        if (startingIndex > endingIndex)
        {
            return 0;
        }

        if (startingIndex == endingIndex)
        {
            return arr[startingIndex];
        }

        int[] dp = new int[endingIndex - startingIndex + 1];

        dp[0] = arr[startingIndex];
        dp[1] = Math.Max(arr[startingIndex], arr[startingIndex + 1]);

        for (int i = startingIndex + 2; i <= endingIndex; i++)
        {
            dp[i - startingIndex] = Math.Max(dp[i - startingIndex - 2] + arr[i], dp[i - startingIndex - 1]);
        }

        return dp[dp.Length - 1];
    }
}