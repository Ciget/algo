using System;
namespace Starter
{
    public class BadVersion
    {
        public int FirstBadVersion(int n)
        {
            int minVersion=0, maxVersion = n;
            int pivot = 0;
            while(minVersion<=maxVersion)
            {
                pivot = minVersion + (maxVersion - minVersion) / 2;

                if (isBadVersion(pivot)) maxVersion = maxVersion - 1;
                else minVersion = minVersion + 1;
            }
            return minVersion;
        }

        private bool isBadVersion(int version) {
            return false;
        }
    }
}

