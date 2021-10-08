using System;
namespace Starter
{
    public class TwoNumberSum
    {
        public int[] GetTwoNumbersByTarget(int[] input, int target)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] == target - input[i])
                    {
                        return new int[]{ i, j };
                    }
                }
            }
            return null;
        }
    }
}
