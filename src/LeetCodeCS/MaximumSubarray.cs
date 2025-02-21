public class MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        int result = Int32.MinValue;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            result = Math.Max(result, sum);
            if (sum < 0)
            {
                sum = 0;
            }
        }
        return result;
    }
}