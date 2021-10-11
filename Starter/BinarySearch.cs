using System;
namespace Starter
{
    public class BinarySearch
    {
        public int SearchForTarget(int [] input, int target)
        {
            int left = 0;
            int right = input.Length - 1;

            int pivot;

            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (input[pivot] == target) return pivot;

                if (input[pivot] > target) right = pivot - 1;
                else left = pivot + 1;
            }
            return -1;
        }
    }
}

