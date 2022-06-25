using SpraidSheet;
using System;
using Xunit;

namespace SpreadSheetTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void spreadSheetTest()
        {
            var array = new int[,] 
            {
                { 1, 4, 1, 8 }, 
                { 3, 8, 7, 1 }, 
                { 4, 1, 2, 2 },
            };

            var target = new int[] { 1, 3 }; //счет от нуля.

            var sortTable = SolvingTheProblem.SpreadSheet(array, target); 

            var sortRightTable = new int[,]
            {
                { 1, 1, 1, 1 },
                { 3, 4, 7, 2 },
                { 4, 8, 2, 8 },
            };

            Assert.Equal(sortRightTable, sortTable);
        }

        [Fact]
        public void spreadSheetTest1()
        {
            var array = new int[,]
            {
                { 1, 4, 1 },
                { 3, 8, 7 },
                { 4, 1, 2 },
                { 2, 9, 4 },
            };

            var target = new int[] { 0, 2}; //счет от нуля.

            var sortTable = SolvingTheProblem.SpreadSheet(array, target);

            var sortRightTable = new int[,]
            {
                { 1, 4, 1 },
                { 2, 8, 2 },
                { 3, 1, 4 },
                { 4, 9, 7 }
            };

            Assert.Equal(sortRightTable, sortTable);
        }

        [Fact]
        public void spreadSheetTest2()
        {
            var array = new int[,]
            {
                { 2, 4 },
                { 1, 8 },

            };

            var target = new int[] { 15, 0, -17 }; //счет от нуля.

            var sortTable = SolvingTheProblem.SpreadSheet(array, target);

            var sortRightTable = new int[,]
            {
                { 1, 4 },
                { 2, 8 },
            };

            Assert.Equal(sortRightTable, sortTable);
        }
    }
}
