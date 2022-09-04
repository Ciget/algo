using System;
namespace Starter
{
    public class RotateArray
    {
        public void Rotate(int [] nums, int k)
        {
            int n = nums.Length;
            int start, count = 0, prev, temp, nextIndex, current=0;

            for (start = 0; count < n; start++)
            {
                current = start;
                prev = nums[start];

                do {
                    nextIndex = (current + k) % n;
                    temp = nums[nextIndex];
                    nums[nextIndex] = prev;
                    prev = temp;
                    current = nextIndex;

                    count++;
                } while (start != current);
            }
        }

    }
}

