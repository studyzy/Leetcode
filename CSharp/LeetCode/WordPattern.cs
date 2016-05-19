using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public bool WordPattern(string pattern, string str)
        {
            if (pattern == null || str == null) return false;
            var dict=new Dictionary<char,string>();
            string[] array = str.Split(' ');
            if (pattern.Length != array.Length) return false;
            for(var i=0;i<pattern.Length;i++)
            {
                var c = pattern[i];
                if (!dict.ContainsKey(c))
                {
                    if (dict.ContainsValue(array[i])) return false;
                    dict[c] = array[i];

                }
                else
                {
                    if (dict[c] != array[i]) return false;
                }
            }
            return true;
        }
    }
}
