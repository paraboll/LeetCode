using CSharpProblems.Easy;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task110_BalancedBinaryTreeTests
    {
        [Fact]
        public void IsSymmetric1()
        {
            //       7
            //    5     5
            //   1 2   2 1

            var Node1 = new Task110_BalancedBinaryTree.TreeNode(1);
            var Node2 = new Task110_BalancedBinaryTree.TreeNode(2);

            var Node5_l = new Task110_BalancedBinaryTree.TreeNode(5, Node1, Node2);
            var Node5_r = new Task110_BalancedBinaryTree.TreeNode(5, Node2, Node1);


            var Node7 = new Task110_BalancedBinaryTree.TreeNode(7, Node5_l, Node5_r);

            var result = new Task110_BalancedBinaryTree().IsBalanced(Node7);

            Assert.True(result);
        }

        [Fact]
        public void IsSymmetric2()
        {
            //      1
            //    2   2
            //  3   3
            //4   4

            var Node4 = new Task110_BalancedBinaryTree.TreeNode(4);

            var Node3_l = new Task110_BalancedBinaryTree.TreeNode(3, Node4, Node4);
            var Node3_r = new Task110_BalancedBinaryTree.TreeNode(3);

            var Node2_l = new Task110_BalancedBinaryTree.TreeNode(2, Node3_l, Node3_r);
            var Node2_r = new Task110_BalancedBinaryTree.TreeNode(2);

            var Node1 = new Task110_BalancedBinaryTree.TreeNode(1, Node2_l, Node2_r);

            var result = new Task110_BalancedBinaryTree().IsBalanced(Node1);

            Assert.False(result);
        }
    }
}
