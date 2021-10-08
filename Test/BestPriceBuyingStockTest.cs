using System;
using Xunit;
using Starter;

namespace Test
{
    public class BestPriceBuyingStockTest
    {
        BestPriceBuyingStock stock = new BestPriceBuyingStock();

        [Fact]
        public void ShouldFindBestPrice()
        {
            int[] prices = { 7, 2, 8, 9};
            Assert.Equal(7, stock.GetMaxProfit(prices));
        }
    }
}
