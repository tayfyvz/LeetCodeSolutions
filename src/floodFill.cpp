#include <iostream>
#include <vector>
#include <stack>

using namespace std;
class Solution {
public:
    vector<vector<int>> floodFill(vector<vector<int>>& image, int sr, int sc, int color) 
    {
        if (image[sr][sc] == color)
        {
            return image;
        }
        int row = image.size();
        int column = image[0].size();

        stack<pair<int, int>> stack;
        vector<vector<bool>> visited(row, vector<bool>(column, false));
        
        stack.push({ sr, sc });
        visited[sr][sc] = true;

        while (!stack.empty())
        {
            pair<int, int> cord = stack.top();
            stack.pop();
            int oldColor = image[cord.first][cord.second];
            image[cord.first][cord.second] = color;

            if (cord.first + 1 < row && !visited[cord.first + 1][cord.second] && image[cord.first + 1][cord.second] == oldColor)
            {
                stack.push({ cord.first + 1, cord.second });
                visited[cord.first + 1][cord.second] = true;
            }
            if (cord.first - 1 >= 0 && !visited[cord.first - 1][cord.second] && image[cord.first - 1][cord.second] == oldColor)
            {
                stack.push({ cord.first - 1, cord.second });
                visited[cord.first - 1][cord.second] = true;
            }
            if (cord.second + 1 < column && !visited[cord.first][cord.second + 1] && image[cord.first][cord.second + 1] == oldColor)
            {
                stack.push({ cord.first, cord.second + 1 });
                visited[cord.first][cord.second + 1] = true;
            }
            if (cord.second - 1 >= 0 && !visited[cord.first][cord.second - 1] && image[cord.first][cord.second - 1] == oldColor)
            {
                stack.push({ cord.first, cord.second - 1 });
                visited[cord.first][cord.second - 1] = true;
            }
         
        }
        return image;

    }
};