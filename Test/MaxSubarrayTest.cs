using System;
using Xunit;
using Starter;

namespace Test
{
    public class MaxSubarrayTest
    {
        MaxSubarray subarray = new MaxSubarray();

        [Fact]
        public void ShouldCalculateMax() {
            int[] inputArray = { 1,2 -4, 90,-2, 4};
            Assert.Equal(92, subarray.CalculateMaxSum(inputArray));
        }
    }
}
