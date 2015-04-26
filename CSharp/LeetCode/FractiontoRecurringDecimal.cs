using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            bool negative = (numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0);

            long numerator1 = numerator;
            long denominator1 = denominator;
            if (numerator < 0)
            {
                numerator1 = -numerator1;
            }
            if (denominator < 0)
            {
                denominator1 = -denominator1;
            }
            long zs = numerator1/denominator1;
            long m =(numerator1 % denominator1);
           
            if (m== 0)
            {
                return (negative ? "-" : "") + zs.ToString();
            }
            var ysList = new List<long>();
            ysList.Add(m);
            StringBuilder sb=new StringBuilder();
            int startIdx = 0;
            while (true)
            {
                m = m*10;
                var n =( m/denominator1);
                sb.Append(n.ToString());
                m =( m%denominator1);
                if (ysList.Contains(m))
                {
                    startIdx = ysList.IndexOf(m);
                    break;
                }
                if (m == 0) //Not Recurring
                {
                    return (negative?"-":"")+  zs + "." + sb.ToString();
                }
                ysList.Add(m);
            }
            var xs = sb.ToString();
            return (negative ? "-" : "") + zs + "." + xs.Substring(0, startIdx) + "(" + xs.Substring(startIdx) + ")";
       
        
        }
    }
}
