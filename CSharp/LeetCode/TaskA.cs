using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
    partial class Solution
    {
        public int solutionA(string E, string L)
        {
            Regex regex = new Regex(@"(\d{2}):(\d{2})");
            var start = regex.Match(E);
            var startHour = Convert.ToInt32(start.Groups[1].Value);
            var startMin = Convert.ToInt32(start.Groups[2].Value);
            var end = regex.Match(L);
            var endHour = Convert.ToInt32(end.Groups[1].Value);
            var endMin = Convert.ToInt32(end.Groups[2].Value);

            var totalMins = endHour*60 + endMin - startHour*60 - startMin;
            int totalFee = 2;
            int totalHours = (int) Math.Ceiling(totalMins/60.0);
            if (totalHours > 0)
            {
                totalFee += 3;
                totalHours--;
                totalFee += totalHours*4;
            }
            return totalFee;
        }
    }
}