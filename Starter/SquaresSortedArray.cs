using System;
namespace Starter
{
    public class SquaresSortedArray
    {
        public int[] SquaresArray(int[] input)
        {
            int n = input.Length;
            int right = n - 1, left = 0;
            int[] result = new int[n];

            for (int i = n-1; i >= 0; i--)
            {
                int square;

                if (Math.Abs(input[left]) < Math.Abs(input[right]))
                {
                    square = input[right];
                    right--;
                }
                else {
                    square = input[left];
                    left++;
                }

                result[i] = square * square;
            }

            return result;
        }
    }
}

