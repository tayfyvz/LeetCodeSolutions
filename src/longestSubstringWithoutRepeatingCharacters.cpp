class Solution {
public:
    int lengthOfLongestSubstring(string s) {

        unordered_set<char> set;

        int left = 0;

        int maxLen = 0;

        for (int right = 0; right < s.length(); right++)
        {
            char c = s[right];
            if (set.find(c) == set.end())
            {
                set.insert(c);
            }
            else
            {
                while (set.find(c) != set.end())
                {
                    set.erase(s[left]);
                    left++;
                }
                set.insert(c);
            }

            maxLen = max(maxLen, (right - left) + 1);
        }

        return maxLen;
    }
};