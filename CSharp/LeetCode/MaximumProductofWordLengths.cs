using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// 用32位int来表示每个字母是否出现，然后进行与运算来表示是否有重复字符
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int MaxProduct(string[] words)
        {
            Dictionary<int,int> dic=new Dictionary<int, int>();
            foreach (var word in words)
            {
                int key = 0;
                foreach (var c in word)
                {
                    var bit = 1 << (c - 'a');
                    key = key | bit;
                }
                if (dic.ContainsKey(key))
                {
                    dic[key] = Math.Max(dic[key], word.Length);
                }
                else
                {
                    dic[key] = word.Length;
                }
            }
            int result = 0;
           var keys= dic.Keys.ToArray();
            for (int i = 0; i < dic.Count-1; i++)
            {
                
                for (int j = i+1; j < dic.Count; j++)
                {
                    if ((keys[i] & keys[j]) == 0)
                    {
                        result = Math.Max(result, dic[keys[i]]*dic[keys[j]]);
                    }
                }
            }
            return result;
        }
    }
}
