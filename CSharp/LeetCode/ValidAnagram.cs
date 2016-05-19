using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null&&t==null) return true;
            if (s == null || t == null) return false;
            var sDic = GetDic(s);
            var tDic = GetDic(t);
            if (sDic.Count != tDic.Count) return false;
            foreach (var skv in sDic)
            {
                if(!tDic.ContainsKey(skv.Key)) return false;

                if (tDic[skv.Key] != skv.Value) return false;
            }
            return true;
        }

        private IDictionary<char, int> GetDic(string s)
        {
           
            var result=new Dictionary<char,int>();
           
            foreach (var c in s)
            {
                if (result.ContainsKey(c)) result[c]++;
                else
                {
                    result[c] = 1;
                }
            }
            return result;
        } 
    }
}
