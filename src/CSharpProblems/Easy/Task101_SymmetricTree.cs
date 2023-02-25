using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    public class Task101_SymmetricTree
    {
        //101. Symmetric Tree

        //Given the root of a binary tree, check whether it is
        //  a mirror of itself (i.e., symmetric around its center).

        //Input: root = [1,2,2,3,4,4,3]
        //Output: true

        //Input: root = [1,2,2,null,3,null,3]
        //Output: false

        // Follow up: Could you solve it both recursively and iteratively?


        //Definition for a binary tree node.
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

        // Runtime 106 ms Beats 68.86%
        // Memory 41 MB Beats 6.79%
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }
        
            if (left.val != right.val)  return false;

            var temp1 = IsSymmetric(left.left, right.right);
            var temp2 = IsSymmetric(left.right, right.left);

            return temp1 && temp2;
        }
    }
}
