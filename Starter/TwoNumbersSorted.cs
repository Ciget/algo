using System;
namespace Starter
{
    public class TwoNumbersSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            int sum;

            while (left < right)
            {
                sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum < target)
                {
                    left++;
                }
                else {
                    right--;
                }
            }
            return new int[]{ -1, -1};
        }
    }
}

