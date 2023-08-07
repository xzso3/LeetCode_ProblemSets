public class LeetCode_94
{
    public List<int> result = new List<int>();

    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return new int[0];
        Traversal(root);
        return result;
    }

    public void Traversal(TreeNode node)
    {
        // SEARCH LEFT NODE
        if (node.left != null)
        {
            Traversal(node.left);
        }
        // ADD SELF
        result.Add(node.val);
        // SEARCH RIGHT NODE
        if (node.right != null)
        {
            Traversal(node.right);
        }
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