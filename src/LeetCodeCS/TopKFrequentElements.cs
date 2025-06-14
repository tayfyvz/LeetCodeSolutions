
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] result = new int[k];    

        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!dict.ContainsKey(num))
            {
                dict[num] = 0;
            }

            dict[num]++;
        }

        return dict.OrderByDescending(pair => pair.Value)
                             .Take(k)
                             .Select(pair => pair.Key)
                             .ToArray();
    }
}