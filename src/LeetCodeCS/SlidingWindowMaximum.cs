using System.Collections.Generic;

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        List<int> result = new List<int>();
        LinkedList<int> window = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while(window.Count > 0 && window.First.Value < i - k + 1)
            {
                window.RemoveFirst();
            }

            while(window.Count > 0 && nums[i] > nums[window.Last.Value])
            {
                window.RemoveLast();
            }

            window.AddLast(i);

            if(i >= k - 1)
            {
                result.Add(nums[window.First.Value]);
            }
        }

        return result.ToArray();
    }
}