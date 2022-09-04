using System;
using Xunit;
using Starter;

namespace Test
{
    public class TwoNumbersSortedTest
    {
        TwoNumbersSorted ts = new TwoNumbersSorted();

        [Fact]
        public void ShouldFindIndexes()
        {
            int[] input = { 2, 7, 11, 15 };
            var result = ts.TwoSum(input, 9);

            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
        }
    }
}

