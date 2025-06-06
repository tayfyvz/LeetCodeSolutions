
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

public class NodeInfo
{
    public TreeNode treeNode;
    public int row;
    public int col;

    public NodeInfo(TreeNode treeNode, int row, int col)
    {
        this.treeNode = treeNode;
        this.row = row;
        this.col = col;
    }
}

public class Solution
{
    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        SortedDictionary<int, List<KeyValuePair<int, int>>> columnDic = new SortedDictionary<int, List<KeyValuePair<int, int>>>();

        Queue<NodeInfo> queue = new Queue<NodeInfo>();

        queue.Enqueue(new NodeInfo(root, 0, 0));

        while(queue.Count() > 0)
        {
            NodeInfo info = queue.Dequeue();

            TreeNode node = info.treeNode;
            int row = info.row;
            int col = info.col;

            if(!columnDic.ContainsKey(col))
            {
                columnDic[col] = new List<KeyValuePair<int, int>>();
            }

            columnDic[col].Add(new KeyValuePair<int, int>(row, node.val));

            if (node.left != null)
            {
                queue.Enqueue(new NodeInfo(node.left, row + 1, col - 1));
            }

            if(node.right != null)
            {
                queue.Enqueue(new NodeInfo(node.right, row + 1, col + 1));
            }
        }

        foreach(var entity in columnDic)
        {
            entity.Value.Sort((a, b) =>
            {
                if(a.Key == b.Key)
                {
                    return a.Value.CompareTo(b.Value);
                }

                return a.Key.CompareTo(b.Key);
            });

            List<int> column = new List<int>();
            foreach(var pair in entity.Value)
            {
                column.Add(pair.Value);
            }

            result.Add(column);
        }

        return result;
    }
}