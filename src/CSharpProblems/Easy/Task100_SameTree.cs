using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    //100. Same Tree 

    //Given the roots of two binary trees p and q, write
    //  a function to check if they are the same or not.

    //Two binary trees are considered the same if they are
    //  structurally identical, and the nodes have the same value.

    public class Task100_SameTree
    {
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

        //Runtime 96 ms Beats 83.51%
        //Memory 40.1 MB Beats 25.73%
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            //if (p == null && q == null) return true;
            //if (q == null || p == null) return false;

            if (q == null || p == null)
            {
                return q == p;
            }

            if (p.val != q.val) return false;

            var rightNote = IsSameTree(p.right, q.right);
            var leftNote = IsSameTree(p.left, q.left);

            return rightNote && leftNote;
        }
    }
}
