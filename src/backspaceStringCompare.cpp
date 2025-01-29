#include <iostream>
#include <stack>
using namespace std;

class Solution {
public:
    bool backspaceCompare(string s, string t) 
    {
        return getString(s) == getString(t);
    }

    string getString(string s)
    {
        stack<char> stack;

        for (int i = 0; i < s.size(); i++)
        {
            if (s[i] == '#')
            {
                if (!stack.empty())
                {
                    stack.pop();
                }
            }
            else
            {
                stack.push(s[i]);
            }
        }
        string str = "";
        while (!stack.empty())
        {
            str += stack.top();
            stack.pop();
        }

        return str;
    }
};