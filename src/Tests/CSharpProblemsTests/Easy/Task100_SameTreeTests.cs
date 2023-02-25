using CSharpProblems.Easy;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task100_SameTreeTests
    {

        [Fact]
        public void IsSameTree1()
        {
            //       7
            //    5     9
            //   3 6   8 10

            var Node3 = new Task100_SameTree.TreeNode(3);
            var Node6 = new Task100_SameTree.TreeNode(6);
            var Node8 = new Task100_SameTree.TreeNode(8);
            var Node10 = new Task100_SameTree.TreeNode(10);

            var Node5 = new Task100_SameTree.TreeNode(5, Node3, Node6);
            var Node9 = new Task100_SameTree.TreeNode(9, Node8, Node10);

            var Node7 = new Task100_SameTree.TreeNode(7, Node5, Node9);

            var result = new Task100_SameTree().IsSameTree(Node7, Node7);

            Assert.True(result);
        }
    }
}
