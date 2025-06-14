using System.Collections.Generic;

public class Solution
{
    public string MinWindow(string s, string t)
    {
        if(t.Length > s.Length)
        {
            return "";
        }

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in t)
        {
            if (!dict.ContainsKey(c))
            {
                dict[c] = 0;
            }

            dict[c]++;
        }

        int remaining = t.Length;
        int start = 0;
        int end = 0;

        int minLen = int.MaxValue;
        int minStart = 0;

        while(end < s.Length)
        {
            if (dict.ContainsKey(s[end]))
            {
                
                if(dict[s[end]] > 0)
                {
                    remaining--;
                }

                dict[s[end]]--;
            }
            end++;

            while (remaining == 0)
            {
                if((end - start) < minLen)
                {
                    minLen = end - start;
                    minStart = start;
                }


                if (dict.ContainsKey(s[start]))
                {
                    dict[s[start]]++;

                    if(dict[s[start]] > 0)
                    {
                        remaining++;
                    }
                }

                start++;
            }
        }

        if (minLen == int.MaxValue)
        {
            return "";
        }
        else
        {
            return s.Substring(minStart, minLen);
        }

    }
}