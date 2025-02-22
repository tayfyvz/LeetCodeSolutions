public class ValidateBinarySearchTree
{
    public bool IsValidBST(TreeNode root) 
    {
        return Helper(root, long.MinValue, long.MaxValue);
    }

    private bool Helper(TreeNode root, long min, long max)
    {
        if (root == null)
        {
            return true;
        }

        if (!(root.val > min && root.val < max))
        {
            return false;
        }
        
        return Helper(root.left, min, root.val) && Helper(root.right, root.val, max);
    }
}