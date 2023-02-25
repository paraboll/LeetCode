using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task257_BinaryTreePathsTests
    {
        [Fact]
        public void IsSymmetric1()
        {
            //       4
            //    2     7
            //   1 3   6 9

            var Node1 = new Task257_BinaryTreePaths.TreeNode(1);
            var Node3 = new Task257_BinaryTreePaths.TreeNode(3);
            var Node6 = new Task257_BinaryTreePaths.TreeNode(6);
            var Node9 = new Task257_BinaryTreePaths.TreeNode(9);

            var Node2 = new Task257_BinaryTreePaths.TreeNode(2, Node1, Node3);
            var Node7 = new Task257_BinaryTreePaths.TreeNode(7, Node6, Node9);

            var Node4 = new Task257_BinaryTreePaths.TreeNode(4, Node2, Node7);

            var Node2_invert = new Task257_BinaryTreePaths.TreeNode(2, Node3, Node1);
            var Node7_invert = new Task257_BinaryTreePaths.TreeNode(7, Node9, Node6);

            var Node4_invert = new Task257_BinaryTreePaths.TreeNode(4, Node7_invert, Node2_invert);


            var result = new Task257_BinaryTreePaths().BinaryTreePaths(Node4);

            //Assert.Equal(Node4_invert, result);
        }
    }
}
