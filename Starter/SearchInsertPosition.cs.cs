using System;

namespace Starter
{
    public class SearchInsertPosition
    {
        public int FindIndex(int [] nums, int target)
        {
            int left = 0, right = nums.Length;
            int pivot;

            while (left <= right )
            {
                pivot = left + (right - left) / 2;

                if (pivot >= nums.Length) return pivot;

                if (nums[pivot] == target) return pivot;
                
                if (nums[pivot] > target) right = right - 1;
                else left = left + 1;
            }
            return left;
        }
    }
}

