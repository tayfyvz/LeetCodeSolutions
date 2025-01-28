#include <iostream>
#include <stack>
#include <map>
using namespace std;

class Solution {
public:
    bool isValid(string s) 
    {
        int size = s.size();
        
        if (size == 0 ||
            size % 2 == 1)
        {
            return false;
        }

        stack<char> stack;
        map<char, char> map =
        {
            {')' , '('},
            {'}' , '{'},
            {']' , '['}
        };

        for (char c : s) 
        {
            if (map.find(c) == map.end())
            {
                stack.push(c);
            }
            else if(!stack.empty() && map[c] == stack.top())
            {
                stack.pop();
            }
            else
            {
                return false;
            }
        }

        return stack.empty();
    }
};