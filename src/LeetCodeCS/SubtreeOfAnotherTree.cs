public class SubtreeOfAnotherTree
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        return Helper(root, subRoot);
    }

    private bool Helper(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
        {
            return false;
        }

        if (IsSame(root, subRoot))
        {
            return true;
        }
        
        bool left = Helper(root.left, subRoot);
        bool right = Helper(root.right, subRoot);
        
        return left || right;
    }

    private bool IsSame(TreeNode root, TreeNode subRoot)
    {
        if (root == null && subRoot == null)
        {
            return true;
        }

        if (root == null || subRoot == null)
        {
            return false;
        }

        if (root.val != subRoot.val)
        {
            return false;
        }
        
        return IsSame(root.left, subRoot.left) && IsSame(root.right, subRoot.right);
    }
}