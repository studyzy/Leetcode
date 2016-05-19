using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string ReverseVowels(string s)
        {
            if (s == null) return null;
            string vowels = "aeiouAEIOU";
            StringBuilder sb=new StringBuilder();
            var point = s.Length - 1;
            foreach (var c in s)
            {
                if (vowels.Contains(c))
                {
                    for (var i = point; i >= 0; i--)
                    {
                        if (vowels.Contains(s[i]))
                        {
                            point = i - 1;
                            sb.Append(s[i]);
                            break;
                        }
                    }
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
