using System;
using System.Collections.Generic;

namespace Starter
{
    public class DuplicateFinder
    {
        public DuplicateFinder()
        {
        }

        public bool HasDuplicate(int[] input) {
            List<int> hash = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!hash.Contains(input[i]))
                {
                    hash.Add(input[i]);
                }
                else return true;
            }
            return false;
        }
    }
}
