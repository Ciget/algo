using System;
using Starter;
using Xunit;

namespace Test
{
    public class DuplicateFinderTest
    {
        DuplicateFinder finder = new DuplicateFinder();
        
        public DuplicateFinderTest()
        {
        }

        [Fact]
        public void ShouldFindDuplicates()
        {
            int[] hasDuplicates ={ 1, 2, 3, 2};
            Assert.True(finder.HasDuplicate(hasDuplicates));
        }

        [Fact]
        public void ShouldNotFindDuplicates()
        {
            int[] hasDuplicates = { 1, 2, 3, 20 };
            Assert.False(finder.HasDuplicate(hasDuplicates));
        }
    }
}
