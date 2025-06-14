public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        if(k == 0 || nums.Length == 0)
        {
            return 0.0;
        }

        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        int newSum = sum;

        for (int i = k; i < nums.Length; i++)
        {
            newSum += nums[i] - nums[i - k];

            if (newSum > sum)
            {
                sum = newSum;
            }
        }

        return sum / (double)k;
        // 1 2 3 4 5
        // k = 3
        // i = 3
        
    }
}