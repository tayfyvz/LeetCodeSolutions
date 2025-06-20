#include <iostream>

using namespace std;

struct TreeNode {
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode(int x) : val(x), left(NULL), right(NULL) {}
};

class Solution {
public:
    TreeNode* lowestCommonAncestor(TreeNode* root, TreeNode* p, TreeNode* q) 
    {
        if (!root)
        {
            return nullptr;
        }
        if (root->val == p->val || root->val == q->val)
        {
            return root;
        }

        TreeNode* left = lowestCommonAncestor(root->left, p, q);
        TreeNode* right = lowestCommonAncestor(root->right, p, q);

    
        if (left && right)
        {
            return root;
        }

        if (left)
        {
            return left;
        }

        if (right)
        {
            return right;
        }

        return nullptr;
    }
};