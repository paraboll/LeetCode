using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    //Given a binary tree, determine if it is height-balanced.

    /*
        Input: root = [3,9,20,null,null,15,7]
        Output: true

        Input: root = [1,2,2,3,3,null,null,4,4]
        Output: false  

        Input: root = []
        Output: true
    */


    //Definition for a binary tree node.
    public class Task110_BalancedBinaryTree
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

        //Runtime 113 ms Beats 69.60%
        //Memory 43.2 MB Beats 18.63%
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            int leftH = FindHeight(root.left);
            int rightH = FindHeight(root.right);

            if (Math.Abs(leftH - rightH) > 1) return false;

            var left = IsBalanced(root.left);
            var right = IsBalanced(root.right);

            return left && right;
        }

        private int FindHeight(TreeNode root)
        {
            if (root == null) return 0;

            int leftHeight = FindHeight(root.left);
            int rightHeight = FindHeight(root.right);

            return 1 + Math.Max(leftHeight, rightHeight);
        }


        public bool IsBalanced2(TreeNode root)
        {
            return height(root) != -1;
        }

        public static int height(TreeNode root)
        {
            if (root == null) return 0;

            int L = height(root.left);
            int R = height(root.right);

            if (L == -1 || R == -1 || Math.Abs(L - R) > 1)
                return -1;  // UnBalanced
            else
                return Math.Max(L, R) + 1; // Height Calculation
        }
    }
}
