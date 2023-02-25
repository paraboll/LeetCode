using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    // Given the root of a binary tree, invert the tree, and return its root.

    // Input: root = [4,2,7,1,3,6,9]
    // Output: [4,7,2,9,6,3,1]
    public class Task226_InvertBinaryTree
    {
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

        //Runtime 92 ms Beats 68.69%
        //Memory 38.4 MB Beats 6.68%
        public TreeNode InvertTreeMy(TreeNode root)
        {
            if (root == null) return null;

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTreeMy(root.left);
            InvertTreeMy(root.right);

            return root;
        }

        //Runtime 99 ms Beats 53.21%
        //Memory 38.4 MB Beats 13.72%
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            TreeNode newtree = new TreeNode(root.val);
            newtree.left = InvertTree(root.right);
            newtree.right = InvertTree(root.left);

            return newtree;
        }

        public TreeNode invertTreeIter(TreeNode root)
        {
            if (root == null) return null;
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode node = queue.Dequeue();

                Swap(node);

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            return root;
        }

        public void Swap(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
        }
    }
}
