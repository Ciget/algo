using System;
namespace Starter
{
    public class MaxSubarray
    {
        public int CalculateMaxSum(int [] input) {
            int currentArray = input[0];
            int maxArray = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                int num = input[i];
                currentArray = Math.Max(num, currentArray + num);
                maxArray = Math.Max(maxArray, currentArray );
            }

            return maxArray;
        }
    }
}
