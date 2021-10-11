using System;
using Xunit;
using Starter;

namespace Test
{
    public class BinarySearchTest
    {
        BinarySearch bs = new BinarySearch();

        [Fact]
        public void ShouldFindTarget()
        {
            int[] input = { -1, 0, 3, 5, 9, 12 };
            int target = 9;

            Assert.Equal(4, bs.SearchForTarget(input, target));

        }
    }
}

