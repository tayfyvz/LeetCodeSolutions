#include <iostream>
using namespace std;

class Solution {
public:
    int climbStairs(int n) 
    {
        if (n <= 3)
        {
            return n;
        }

        int last = 3;
        int prev = 2;
        int result = 0;

        for (int i = 3; i < n; i++)
        {
            result = last + prev;
            prev = last;
            last = result;
        }

        return result;
    }
};