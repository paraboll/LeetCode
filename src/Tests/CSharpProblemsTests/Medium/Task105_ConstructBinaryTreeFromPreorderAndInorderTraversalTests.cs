using CSharpProblems.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Medium
{
    public class Task105_ConstructBinaryTreeFromPreorderAndInorderTraversalTests
    {
        [Fact]
        public void BuildTree()
        {
            var preorder = new int[] { 3, 9, 20, 15, 7 };
            var inorder = new int[] { 9, 3, 15, 20, 7 };

            var result = new Task105_ConstructBinaryTreeFromPreorderAndInorderTraversal()
                                .BuildTree(preorder, inorder);

        }
    }
}
