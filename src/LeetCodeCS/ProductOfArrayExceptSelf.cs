public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int totalProduct = 1;
        int numOfZeroes = 0;

        int[] result = new int[nums.Length];
        Array.Fill(result, 0);
        
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                numOfZeroes++;
            }
            else
            {
                totalProduct *= nums[i];
            }
        }

        if (numOfZeroes == 0)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = totalProduct / nums[i];
            }
        }
        else if (numOfZeroes == 1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = totalProduct;
                }
            }
        }
        return result;
    }
}