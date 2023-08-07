public class LeetCode_101
{
    public bool IsSymmetric(TreeNode root)
    {
        return CheckSymmetric(root.left, root.right);
    }

    public bool CheckSymmetric(TreeNode left, TreeNode right)
    {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        if (left.val != right.val) return false;

        return CheckSymmetric(left.left, right.right) && CheckSymmetric(left.right, right.left);
    }

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
}