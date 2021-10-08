﻿using System;
using Starter;
using Xunit;

namespace Test
{
    public class TwoNumberSumTest
    {
        TwoNumberSum sum = new TwoNumberSum();

        [Fact]
        public void ShouldFindCorrectMatch()
        {
            int[] input = {1,3,6,9 };
            int [] result = sum.GetTwoNumbersByTarget(input, 10);
            Assert.Equal(1, result[0]);
            Assert.Equal(9, result[3]);
        }
    }
}
