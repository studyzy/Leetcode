using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            Dictionary<char, string> Mapping = new Dictionary<char, string>() { { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" } };
            
            foreach (char d in digits)
            {
                var strings = result;
                result=new List<string>();
                foreach (var c in Mapping[d])
                {
                    if (strings.Count == 0)
                    {
                        result.Add(c.ToString());
                    }
                    else
                    {
                        foreach (var s in strings)
                        {
                            result.Add(s + c);
                        }
                    }
                }
            }
            return result;
        }
    }
}
