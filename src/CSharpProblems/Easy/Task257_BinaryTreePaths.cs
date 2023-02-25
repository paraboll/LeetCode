using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    //257. Binary Tree Paths
    //Given the root of a binary tree, return all
    //  root-to-leaf paths in any order.

    //A leaf is a node with no children.

    // Input: root = [1,2,3,null,5]
    // Output: ["1->2->5","1->3"]
    public class Task257_BinaryTreePaths
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

        // Runtime 162 ms Beats 71.78%
        // Memory 43.8 MB Beats 49.51%

        private List<string> paths = new List<string>();
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            FindPath(root);
            return paths;
        }

        public void FindPath(TreeNode node, string currentPath = null)
        {
            if (node == null) return;

            var newCurrentPath = currentPath != null
                ? currentPath + "->" + node.val
                : node.val.ToString(); //1 элемент без -> 

            var isLeaf = node.left == null && node.right == null;
            if (isLeaf)
            {
                paths.Add(newCurrentPath);
            }
            else
            {
                FindPath(node.left, newCurrentPath);
                FindPath(node.right, newCurrentPath);
            }
        }
    }
}
