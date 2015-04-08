using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/generate-parentheses/
        /// TODO 没有做出来，需要进一步思考
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<string> GenerateParenthesis(int n)
        {
            if (n == 1)
            {
                return new List<string>() {"()"};
            }
            if (n==0)
            {
                return new List<string>(){""};
            }
            var result = new List<string>();
            for (var i = 0; i < n; i++)
            {
                foreach (var inner in GenerateParenthesis(i))
                {
                    foreach (var outer in GenerateParenthesis(n - 1 - i))
                    {
                        result.Add("("+inner+")"+outer);
                    }
                }
            }
            return result;
        }
       
    }
}
