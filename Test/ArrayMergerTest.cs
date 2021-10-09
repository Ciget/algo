using System;
using Starter;
using Xunit;

namespace Test
{
    public class ArrayMergerTest
    {
        [Fact]
        public void ShouldMergeArrayCorrectly()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3, n = 3;
            int[] nums2 = { 2, 5, 6 };
            

            ArrayMerger am = new ArrayMerger();
            am.Merge(nums1, m, nums2, n);
            Assert.Equal(1, nums1[0]);
            Assert.Equal(2, nums1[1]);
            Assert.Equal(2, nums1[2]);
            Assert.Equal(3, nums1[3]);
            Assert.Equal(5, nums1[4]);
            Assert.Equal(6, nums1[5]);

        }

        [Fact]
        public void ShouldMergeArrayCorrectly2()
        {
            int[] nums1 = { 1};
            int m = 1, n = 0;
            int[] nums2 = {};


            ArrayMerger am = new ArrayMerger();
            am.Merge(nums1, m, nums2, n);
            Assert.Equal(1, nums1[0]);
        }

        [Fact]
        public void ShouldMergeArrayCorrectly3()
        {
            int[] nums1 = { 2, 0 };
            int m = 1, n = 1;
            int[] nums2 = { 1};

            ArrayMerger am = new ArrayMerger();
            am.Merge(nums1, m, nums2, n);
            Assert.Equal(1, nums1[0]);
            Assert.Equal(2, nums1[1]);
        }
    }
}

