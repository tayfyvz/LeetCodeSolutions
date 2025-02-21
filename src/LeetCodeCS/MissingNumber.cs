public class MissingNumber
{
    public int Solution(int[] nums)
    {
        if (nums.Length == 0)
        {
            return -1;
        }
        
        int[] nums2 = new int[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            nums2[nums[i]] = 1;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (nums2[i] == 0)
            {
                return i;
            }
        }
        
        return -1;
    }    
}