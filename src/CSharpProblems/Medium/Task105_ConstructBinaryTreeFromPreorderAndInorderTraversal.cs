using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Medium
{
    //105. Construct Binary Tree from Preorder and Inorder Traversal

    //Given two integer arrays preorder and inorder where preorder 
    //is the preorder traversal of a binary tree and inorder is the 
    //inorder traversal of the same tree, construct and return the binary tree.

    //Example 1:
    //Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
    //Output: [3,9,20,null,null,15,7]
    
    //Example 2:
    //Input: preorder = [-1], inorder = [-1]
    //Output: [-1]

    //Constraints:
    //    1 <= preorder.length <= 3000
    //    inorder.length == preorder.length
    //    -3000 <= preorder[i], inorder[i] <= 3000
    //    preorder and inorder consist of unique values.
    //    Each value of inorder also appears in preorder.
    //    preorder is guaranteed to be the preorder traversal of the tree.
    //    inorder is guaranteed to be the inorder traversal of the tree.


    public class Task105_ConstructBinaryTreeFromPreorderAndInorderTraversal
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

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || inorder == null ||
                preorder.Length == 0 || inorder.Length == 0)
            {
                return null;
            }

            var map = new Dictionary<int,int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                 map.Add(inorder[i], i);
            }
               
            return createTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1, map);
        }

        public TreeNode createTree(int[] preorder, int preorderStart, int preorderEnd, 
                                   int[] inorder, int inorderStart, int inorderEnd, 
                                   Dictionary<int,int> map)
        {
            if (preorderStart > preorderEnd || inorderStart > inorderEnd)
            {
                return null;
            }

            int rootVal = preorder[preorderStart];
            TreeNode root = new TreeNode(rootVal);

            int rootIndex = map[rootVal];
            int len = rootIndex - inorderStart;

            root.left = createTree(preorder, preorderStart + 1, preorderStart + len, 
                                   inorder, inorderStart, rootIndex - 1, map);
            root.right = createTree(preorder, preorderStart + len + 1, preorderEnd, 
                                    inorder, rootIndex + 1, inorderEnd, map);
            
            return root;
        }
    }
}
