using System;
using Xunit;
using Starter;

namespace Test
{
    public class RotateArrayTest
    {
        RotateArray ra = new RotateArray();

        [Fact]
        public void ShouldRotateArray()
        {
            int k = 3;
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            ra.Rotate(nums, k);

            Assert.Equal(5, nums[0]);
            Assert.Equal(6, nums[1]);
            Assert.Equal(7, nums[2]);
            Assert.Equal(1, nums[3]);
            Assert.Equal(2, nums[4]);
            Assert.Equal(3, nums[5]);
            Assert.Equal(4, nums[6]);
        }
    }
}

