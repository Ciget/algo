using System;
namespace Starter
{
    public class ArrayMerger
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] output = new int[m+n];
            int mIndex = 0, nIndex = 0 ;

            for (int i = 0; i < m+n; i++)
            {
                
                if (mIndex < m && (n == 0 || nIndex >= n || nums1[mIndex] <= nums2[nIndex]))
                {
                    output[i] = nums1[mIndex];
                    mIndex++;
                }
                else {
                    output[i] = nums2[nIndex];
                    nIndex++;
                }
            }

            for (int i = 0; i < m + n; i++)
            {
                nums1[i] = output[i];
            }
        }
    }
}

