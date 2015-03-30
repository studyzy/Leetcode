using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/roman-to-integer/
        /// 参考：http://zh.wikipedia.org/wiki/%E7%BD%97%E9%A9%AC%E6%95%B0%E5%AD%97
        /// 罗马数字共有7个，即I（1）、V（5）、X（10）、L（50）、C（100）、D（500）和M（1000）
        /// </summary>
        /// <param name="s">Input is guaranteed to be within the range from 1 to 3999.</param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            int result = 0;
            for (var i=0;i< s.Length;i++)
            {
                var c = s[i];
                var nextC = ' ';
                if (i != s.Length - 1)
                {
                    nextC = s[i + 1];
                }
                switch (c)
                {
                    case 'I':
                    {
                        if (nextC == 'V' || nextC == 'X')
                        {
                            result -= 1;
                        }
                        else
                        {
                            result += 1;
                        }
                    }
                        break;
                    case 'V':
                    {
                        result += 5;
                    }
                        break;
                    case 'X':
                    {
                        if (nextC == 'L' || nextC == 'C')
                        {
                            result -= 10;
                        }
                        else
                        {
                            result += 10;
                        }
                    }
                        break;
                    case 'L':
                        {
                            result += 50;
                        }
                        break;
                    case 'C':
                        {
                            if (nextC == 'D' || nextC == 'M')
                            {
                                result -= 100;
                            }
                            else
                            {
                                result += 100;
                            }
                        }
                        break;
                    case 'D':
                        {
                            result += 500;
                        }
                        break;
                    case 'M':
                        {
                            result += 1000;
                        }
                        break;
                }
               
            }
            return result;
        }
    }
}
