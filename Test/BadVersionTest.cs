using System;
using Starter;
using Xunit;

namespace Test
{
    public class BadVersionTest
    {
        BadVersion bv = new BadVersion();

        [Fact]
        public void ShouldFindCorrectVersion()
        {
            bv.FirstBadVersion(7);
        }
    }
}

