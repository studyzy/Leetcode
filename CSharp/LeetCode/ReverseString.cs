using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string ReverseString(string s)
        {
            if (s == null) return null;
            StringBuilder sb=new StringBuilder();
            for (var i = s.Length-1; i >=0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
