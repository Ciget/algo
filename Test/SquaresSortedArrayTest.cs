using System;
using Starter;
using Xunit;

namespace Test
{
    public class SquaresSortedArrayTest
    {
        SquaresSortedArray sa = new SquaresSortedArray();

        [Fact]
        public void ShouldReturnSquares()
        {
            int[] input = { -4, -1, 0, 3, 10 };

            var result = sa.SquaresArray(input);
            Assert.Equal(0, result[0]);
            Assert.Equal(1, result[1]);
            Assert.Equal(9, result[2]);
            Assert.Equal(16, result[3]);
            Assert.Equal(100, result[4]);
        }

        [Fact]
        public void ShouldReturnSquares2()
        {
            int[] input = { -7, -3, 2, 3, 11 };

            var result = sa.SquaresArray(input);
            Assert.Equal(4, result[0]);
            Assert.Equal(9, result[1]);
            Assert.Equal(9, result[2]);
            Assert.Equal(49, result[3]);
            Assert.Equal(121, result[4]);
        }
    }
}

