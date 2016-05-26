using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// 动态规划算法,找出从1到n每个数的最小组合
        /// 对于任意给出的n，循环去减去一个平方数，看剩下的数需要几个数字进行组合，
        /// 把剩下数字的组合+1就是现在这种组合。
        /// 找出循环的组合中最小的那个
        /// 思路和CoinChange这个题一模一样
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares(int n)
        {
            var array = new int[n + 1];
            array[0] = 0;
            for (var i = 1; i <= n; i++)
            {
                array[i]=Int32.MaxValue;
                for (int j = 1; j*j <=i ; j++)
                {
                    array[i] = Math.Min(array[i - j*j] + 1, array[i]);
                }
            }
            return array[n];
        }
    }
}
