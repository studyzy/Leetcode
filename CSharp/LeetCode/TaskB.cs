using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public int solution2(int[] A)
        {
            if (A.Length == 0) return 0;
          return Math.Min(30, Cost(A, 0));//月票的情况
        }

        public int Cost(int[] A, int startPoint)
        {
            int dayCount = A.Length - startPoint;
            if (dayCount == 0) return 0;
            if (dayCount <= 3) return 2*dayCount;
            //day count>=4

            int totalCost = 0;
            int startDay = A[startPoint];
            if (A[startPoint + 3] > startDay + 6) //不连续
            {
                totalCost += 2;
                startPoint++;
                totalCost += Cost(A, startPoint);
            }
            else
            {
                //连续的情况下也可能不买

                totalCost = 7;
                int lastDays = A.Length - startPoint;
                int passPoint = 1;
                for (var x = 1; x < Math.Min(7, lastDays); x++)
                {
                    if (A[startPoint + x] <= startDay + 6)
                    {
                        passPoint++;
                    }
                    else
                    {
                        break;
                    }
                }
                totalCost += Cost(A, startPoint+ passPoint);

                int totalCost1 = 2;
                totalCost1 += Cost(A, startPoint + 1);
                totalCost = Math.Min(totalCost, totalCost1);
            }
            return totalCost;

        }
    }
}
