using System.Collections.Generic;

public class Solution
{
    public int MinDeletion(string s, int k)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        foreach (char c in s)
        {
            if(!dict.ContainsKey(c))
            {
                dict[c] = 0;
            }

            dict[c]++;
        }

        if (dict.Count <= k)
        {
            return 0;
        }

        List<KeyValuePair<char, int>> pairs = new List<KeyValuePair<char, int>>(dict);

        pairs.Sort((a, b) => a.Value.CompareTo(b.Value));

        int totalDelCount = 0;
        int desiredDel = pairs.Count - k;

        for (int i = 0; i < desiredDel; i++)
        {
            totalDelCount += pairs[i].Value;
        }

        return totalDelCount;
    }
}