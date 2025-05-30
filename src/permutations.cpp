#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    vector<vector<int>> permute(vector<int>& nums) {
		
		/*vector<vector<int>> result;

		if (nums.size() == 1)
		{
			vector<int> v;
			v.push_back(nums[0]);
			result.push_back(v);
			return result;
		}

		for (int i = 0; i < nums.size(); i++)
		{
			int n = nums[i];

			vector<int> remainingNumbers;
			for (int j = 0; j < nums.size(); j++)
			{
				if (nums[j] != n)
				{
					remainingNumbers.push_back(nums[j]);
				}
			}

			vector<vector<int>> perms = permute(remainingNumbers);

			for (vector<int> perm : perms)
			{
				perm.insert(perm.begin(), n);
				result.push_back(perm);
			}

		}


		return result;*/


		vector<vector<int>> result;

		vector<int> comb;

		vector<bool> visited(nums.size(), false);

		dfs(result, nums, comb, visited);

		return result;
    }

private:

	void dfs(vector<vector<int>>& result, vector<int>& nums, vector<int> comb, vector<bool> visited)
	{
		if (comb.size() == nums.size())
		{
			result.push_back(comb);
			return;
		}

		for (int i = 0; i < nums.size(); i++)
		{
			if (visited[i])
			{
				continue;
			}

			visited[i] = true;
			comb.push_back(nums[i]);

			dfs(result, nums, comb, visited);

			comb.pop_back();
			visited[i] = false;
		}


	}
};