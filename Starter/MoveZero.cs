using System;
namespace Starter
{
    public class MoveZero
    {
        public void Transform(int [] input)
        {
            int lastNonZeroIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    input[lastNonZeroIndex] = input[i];
                    lastNonZeroIndex++;
                }
            }

            for (int i=lastNonZeroIndex; i<input.Length; i++)
            {
                input[i] = 0;
            }
        }
    }
}

