using System;
using Xunit;
using Starter;

namespace Test
{
    public class MoveZeroTest
    {
        MoveZero mz = new MoveZero();

        [Fact]
        public void ShouldMoveAllZerosToEnd()
        {
            int[] input = { 0, 1, 0, 3, 12 };

            mz.Transform(input);

            Assert.Equal(1, input[0]);
            Assert.Equal(3, input[1]);
            Assert.Equal(12, input[2]);
            Assert.Equal(0, input[3]);
            Assert.Equal(0, input[4]);
        }
    }
}

