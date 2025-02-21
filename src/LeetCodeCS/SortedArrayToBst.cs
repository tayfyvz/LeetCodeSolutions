public class SortedArrayToBst
{
    public TreeNode SortedArrayToBST(int[] nums) 
    {
        return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int start, int end)
    {
        if (start > end)
        {
            return null;
        }
        int mid = start + (end - start) / 2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = Helper(nums, start, mid - 1);
        root.right = Helper(nums, mid + 1, end);
        return root;
    }
}