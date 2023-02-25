using CSharpProblems.Easy;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task226_InvertBinaryTreeTests
    {
        [Fact]
        public void IsSymmetric1()
        {
            //       4
            //    2     7
            //   1 3   6 9

            var Node1 = new Task226_InvertBinaryTree.TreeNode(1);
            var Node3 = new Task226_InvertBinaryTree.TreeNode(3);
            var Node6 = new Task226_InvertBinaryTree.TreeNode(6);
            var Node9 = new Task226_InvertBinaryTree.TreeNode(9);

            var Node2 = new Task226_InvertBinaryTree.TreeNode(2, Node1, Node3);
            var Node7 = new Task226_InvertBinaryTree.TreeNode(7, Node6, Node9);

            var Node4 = new Task226_InvertBinaryTree.TreeNode(4, Node2, Node7);

            var Node2_invert = new Task226_InvertBinaryTree.TreeNode(2, Node3, Node1);
            var Node7_invert = new Task226_InvertBinaryTree.TreeNode(7, Node9, Node6);

            var Node4_invert = new Task226_InvertBinaryTree.TreeNode(4, Node7_invert, Node2_invert);


            var result = new Task226_InvertBinaryTree().InvertTree(Node4);

            //Assert.Equal(Node4_invert, result);
        }
    }
}
