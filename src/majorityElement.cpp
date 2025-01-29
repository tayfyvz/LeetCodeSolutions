#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;

class Solution {
public:
    int majorityElement(vector<int>& nums) 
    {
        int size = nums.size();
        unordered_map<int, int> map;

        for (int i = 0; i < size; i++)
        {
            map[nums[i]]++;
            if (map[nums[i]] > size / 2)
            {
                return nums[i];
            }
        }

        return -1;
    }
};