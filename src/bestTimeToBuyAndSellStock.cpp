#include <iostream>
#include <vector>
using namespace std;

class Solution {
public:
    int maxProfit(vector<int>& prices) 
    {
        int maxDifference = 0;
        int minBuy = INT_MAX;

        for (int i = 0; i < prices.size(); i++)
        {
            int price = prices[i];

            if (price < minBuy)
            {
                minBuy = price;
            }
            else if (price - minBuy > maxDifference)
            {
                maxDifference = price - minBuy;
            }
        }

        return maxDifference;
    }
};