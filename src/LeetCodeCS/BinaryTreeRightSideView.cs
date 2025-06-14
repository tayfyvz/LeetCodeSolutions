
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> result = new List<int>();

        SideView(result, root, 0);

        return result;
    }

    private void SideView(IList<int> list, TreeNode node, int level)
    {
        if (node == null) return;

        if (list.Count == level)
        {
            list.Add(node.val);
        }

        SideView(list, node.right, level + 1);
        SideView(list, node.left, level + 1);
    }
}