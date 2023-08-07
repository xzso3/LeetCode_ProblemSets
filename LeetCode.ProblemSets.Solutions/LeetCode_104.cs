public class LeetCode_104
{
    public int MaxDepth(TreeNode root)
    {
        var depth = 0;

        if (root == null)
        {
            return depth;
        }
        
        depth++;
        
        if (root.left == null && root.right == null)
        {
            return depth;
        }

        var leftDepth = MaxDepth(root.left);
        var rightDepth = MaxDepth(root.right);
        return depth + (leftDepth > rightDepth ? leftDepth : rightDepth);

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