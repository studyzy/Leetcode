using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /* The isBadVersion API is defined in the parent class VersionControl.
       bool IsBadVersion(int version); */

    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return 2==version;
        }
    }

    public partial class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            if (n == 1) return 1;
            int left = 1;
            int right = n;

            while (left < right)
            {
                int mid = left + (right - left)/2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return right;
        }
    }
}
