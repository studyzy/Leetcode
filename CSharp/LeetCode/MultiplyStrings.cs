using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/multiply-strings/
        /// 没啥难度，就是模拟乘法的计算过程，最后去掉左边的0
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Multiply(string num1, string num2)
        {
            var result =new int[num1.Length+num2.Length];
             for (var i = 0; i < num2.Length; i++)
             {
                 var c2 = num2[num2.Length - i - 1];
                   int x = c2 - '0';
                var line=Multiply(num1,x);
                 for (int j = 0; j < line.Count; j++)
                 {
                     result[j + i] += line[j];
                 }
            }
            string a = "";
            int step = 0;
            foreach (var i in result)
            {
                a = (i + step)%10 + a;
                step = (i + step)/10;
            }
            if (step != 0)
            {
                a = step + a;
            }
           
            //去掉左边的0
            if (a.IndexOf('0') == 0)
            {
                int p = 0;
                foreach (var c in a)
                {
                    if (c == '0')
                    {
                        p++;
                    }
                    else
                    {
                        break;
                    }
                }
                a = a.Substring(p);
            }
            if (a == "") return "0";
            return a;
        }

        private  IList<int> Multiply(string num1, int x)
        {
            var line = new List<int>();
            for (var i = 0; i < num1.Length; i++)
            {
                line.Add((num1[num1.Length - i - 1] - '0')*x);
            }
            return line;
        }

    }
}
