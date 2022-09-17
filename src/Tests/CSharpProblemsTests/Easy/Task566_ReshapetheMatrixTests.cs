using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task566_ReshapetheMatrixTests
    {
        [Fact]
        public void MatrixReshape1()
        {
            var mat = new int[][] { new int[] { 1, 2 },
                                    new int[] { 3, 4 } };
            int r = 1, c = 4;

            var result = new Task566_ReshapetheMatrix()
                                .MatrixReshape(mat, r, c);

            var resultAnswer = new int[][] { new int[] { 1, 2, 3, 4 } };

            Assert.Equal(resultAnswer, result);
        }

        [Fact]
        public void MatrixReshape2()
        {
            var mat = new int[][] { new int[] { 1, 2 },
                                    new int[] { 3, 4 } };
            int r = 2, c = 4;

            var result = new Task566_ReshapetheMatrix()
                                .MatrixReshape(mat, r, c);

            var resultAnswer = new int[][] { new int[] { 1, 2 },
                                             new int[] { 3, 4 } };

            Assert.Equal(resultAnswer, result);
        }
    }
}
