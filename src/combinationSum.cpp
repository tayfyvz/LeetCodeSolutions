#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    vector<vector<int>> combinationSum(vector<int>& candidates, int target) 
    {
        vector<vector<int>> result;

        vector<int> combination;

        checkCombination(candidates, target, 0, combination, 0, result);

        return result;
    }

private:

    void checkCombination(vector<int>& candidates,
        int target,
        int index,
        vector<int>& combination, 
        int total, 
        vector<vector<int>>& result)
    {
        if (total == target)
        {
            result.push_back(combination);
            return;
        }

        if (total > target || index >= candidates.size())
        {
            return;
        }

        combination.push_back(candidates[index]);
        checkCombination(candidates, target, index, combination, total + candidates[index], result);
        combination.pop_back();
        checkCombination(candidates, target, index + 1, combination, total, result);
    }
};