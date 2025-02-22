public class BinaryTreeLevelOrderTraversal
{

    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        IList<IList<int>> levelOrder = new List<IList<int>>();
        if (root == null)
        {
            return levelOrder;
        }
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            List<int> list = new List<int>();
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                TreeNode node = queue.Dequeue();
                list.Add(node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            levelOrder.Add(list);
        }
        
        return levelOrder;
    }

}