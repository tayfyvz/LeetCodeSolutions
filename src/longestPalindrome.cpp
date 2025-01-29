#include <iostream>
#include <unordered_map>
using namespace std;

class Solution {
public:
    int longestPalindrome(string s) 
    {
        int oddCount = 0;
        unordered_map<char, int> map;
        
        for (char c : s)
        {
            map[c]++;
            if (map[c] % 2 == 1)
            {
                oddCount++;
            }
            else
            {
                oddCount--;
            }
        }

        if (oddCount > 1)
        {
            return s.size() - oddCount + 1;
        }

        return s.size();
    }
};