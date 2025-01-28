#include <vector>
#include <map>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) 
    {
        map<int, int> map;
        vector<int> result;

        for (int i = 0; i < nums.size(); i++)
        {
            int number = nums[i];
            int desiredNum = target - number;
            if (map.find(number) == map.end())
            {
                map[desiredNum] = i;
            }
            else
            {
                result.push_back(map[number]);
                result.push_back(i);
                return result;
            }
            
        }
        
        return result;
    }
};