using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task101_SymmetricTreeTests
    {
        [Fact]
        public void IsSymmetric()
        {
            //       7
            //    5     5
            //   1 2   2 1

            var Node1 = new Task101_SymmetricTree.TreeNode(1);
            var Node2 = new Task101_SymmetricTree.TreeNode(2);

            var Node5_l = new Task101_SymmetricTree.TreeNode(5, Node1, Node2);
            var Node5_r = new Task101_SymmetricTree.TreeNode(5, Node2, Node1);


            var Node7 = new Task101_SymmetricTree.TreeNode(7, Node5_l, Node5_r);

            var result = new Task101_SymmetricTree().IsSymmetric(Node7);

            Assert.True(result);
        }
    }
}
