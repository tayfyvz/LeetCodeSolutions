#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
    vector<vector<int>> merge(vector<vector<int>>& intervals) 
    {
        sort(intervals.begin(), intervals.end(), [](const vector<int>& a, const vector<int>& b) {
            return a[0] < b[0];
            });

        vector<vector<int>> result;

        int left = intervals[0][0];
        int right = intervals[0][1];

        for (int i = 1; i < intervals.size(); i++)
        {   

            if (intervals[i][0] <= right)
            {
                left = min(left, intervals[i][0]);
                right = max(right, intervals[i][1]);
            }
            else
            {
                result.push_back(vector<int>{left, right});

                left = intervals[i][0];
                right = intervals[i][1];
            }
        }

        result.push_back(vector<int>{left, right});

        return result;
    }
};