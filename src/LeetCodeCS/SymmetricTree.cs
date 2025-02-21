

public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root) 
    {
        return CheckSymmetric(root.left, root.right);
    }

    private bool CheckSymmetric(TreeNode p1, TreeNode p2)
    {
        if (p1 == null && p2 == null)
        {
            return true;
        }
        
        if (p1 == null || p2 == null)
        {
            return false;
        }
        
        if (p1.val != p2.val)
        {
            return false;
        }
        
        bool cond1 = CheckSymmetric(p1.left, p2.right);
        bool cond2 = CheckSymmetric(p1.right, p2.left);
        
        return cond1 && cond2;
    }
}