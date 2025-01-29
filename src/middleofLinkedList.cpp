#include <iostream>
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
    ListNode* middleNode(ListNode* head) 
    {
        int size = 0;

        ListNode* curr = head;
        
        while (curr)
        {
            size++;
            curr = curr->next;
        }

        curr = head;

        for (int i = 0; i < size/2; i++)
        {
            curr = curr->next;
        }
        
        return curr;
    }
};