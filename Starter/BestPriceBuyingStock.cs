using System;
namespace Starter
{
    public class BestPriceBuyingStock
    {
        public int GetMaxProfit(int[] input)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]<minPrice)
                {
                    minPrice = input[i];
                }
                else if (input[i] - minPrice > maxProfit)
                {
                    maxProfit = input[i] - minPrice;
                }
            }
            return maxProfit;
        }
    }
}
