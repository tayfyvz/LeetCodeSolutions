#include <iostream>
using namespace std;

class Solution {
public:
    bool isPalindrome(string s) {
        int start = 0;
        int end = s.size() - 1;

        while (start <= end)
        {
            if (!isalnum(s[start]))
            {
                start++;
                continue;
            }

            if (!isalnum(s[end]))
            {
                end--;
                continue;
            }

            if (s[start] != s[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
};