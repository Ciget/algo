using System;
using Xunit;
using Starter;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var t = new Provider().Calc();
            Assert.Equal(20, t);
        }
    }
}
