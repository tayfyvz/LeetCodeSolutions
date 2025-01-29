// The API isBadVersion is defined for you.
// bool isBadVersion(int version);
#include <iostream>
using namespace std;

class Solution {
public:
    int firstBadVersion(int n) 
    {
        int start = 0;
        int end = n;
        int found = 0;

        while (start<=end)
        {
            int mid = start + (end - start) / 2;

            if (isBadVersion(mid))
            {
                found = mid;
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return found;
    }
};