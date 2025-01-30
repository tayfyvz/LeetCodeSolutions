#include <iostream>
#include <vector>

using namespace std;

struct ListNode {
      int val;
      ListNode *next;
      ListNode() : val(0), next(nullptr) {}
      ListNode(int x) : val(x), next(nullptr) {}
      ListNode(int x, ListNode *next) : val(x), next(next) {}
  };
 
class Solution {
public:
    bool isPalindrome(ListNode* head) 
    {
        if (!head)
        {
            return false;
        }

        vector<int> values;
        ListNode* curr = head;

        while (curr)
        {
            values.push_back(curr->val);
            curr = curr->next;
        }

        int start = 0;
        int end = values.size() - 1;

        while (start <= end)
        {
            if (values[start] != values[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
};