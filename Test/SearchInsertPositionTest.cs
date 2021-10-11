using System;
using Xunit;
using Starter;

namespace Test
{
    public class SearchInsertPositionTest
    {
        SearchInsertPosition sp = new SearchInsertPosition();

        [Fact]
        public void ShouldFindIndexToInsert()
        {
            int[] input = { 1, 3, 5, 6 };
            int target = 5;

            Assert.Equal(2, sp.FindIndex(input, target));
        }

        [Fact]
        public void ShouldFindIndexForNonexisting()
        {
            int[] input = { 1, 3, 5, 6 };
            int target = 2;

            Assert.Equal(1, sp.FindIndex(input, target));
        }

        [Fact]
        public void ShouldFindIndexForNonexisting2()
        {
            int[] input = { 1, 3, 5, 6 };
            int target = 7;

            Assert.Equal(4, sp.FindIndex(input, target));
        }
    }
}

