#include <iostream>
using namespace std;

struct TreeNode {
     int val;
     TreeNode *left;
     TreeNode *right;
     TreeNode() : val(0), left(nullptr), right(nullptr) {}
     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
};
 
class Solution {
public:
    bool isBalanced(TreeNode* root) 
    {
        if (!root) 
        {
            return true;
        }

        return CheckHeight(root) != -1;
    }

    int CheckHeight(TreeNode* root) 
    {
        if (!root)
        {
            return 0;
        }
        int leftHeight = CheckHeight(root->left);
        int rightHeight = CheckHeight(root->right);

        if (abs(leftHeight - rightHeight) > 1 || leftHeight == -1 || rightHeight == -1)
        {
            return -1;
        }

        return 1 + max(leftHeight, rightHeight);
    }
};