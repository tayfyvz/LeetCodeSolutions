#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

class Solution {
public:
    vector<vector<int>> getSkyline(vector<vector<int>>& buildings) {
        vector<pair<int, int>> h;

        for (auto b : buildings)
        {
            h.push_back({ b[0], -b[2] });
            h.push_back({ b[1], b[2] });
        }

        sort(h.begin(), h.end());

        multiset<int> m;
        vector<vector<int>> result;

        int curr = 0, prev = 0;

        m.insert(0);

        for (auto i : h)
        {
            if (i.second < 0)
            {
                m.insert(-i.second);
            }
            else
            {
                m.erase(m.find(i.second));
            }

            curr = *m.rbegin();

            if (curr != prev)
            {
                result.push_back({ i.first, curr });
                prev = curr;
            }
        }

        return result;
    }
};