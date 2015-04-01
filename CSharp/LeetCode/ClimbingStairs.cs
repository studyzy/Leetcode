using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/climbing-stairs/
        /// 为了爬到n级楼梯，有两种方法：
        /// 1，爬到n-1级楼梯，然后上一步。
        /// 2，爬到n-2级楼梯，然后上2步。
        /// 所以f(n)=f(n-1)+f(n-2)
        /// 结果就是一个斐波那契数列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            //if (n <= 2)
            //{
            //    return n;
            //}
            //return ClimbStairs(n - 1) + ClimbStairs(n - 2);
            //TODO 递归的速度太慢了，改算法 迭代
            int prev = 0;
            int cur = 1;
            for (int i = 1; i <= n; ++i)
            {
                int tmp = cur;
                cur += prev;
                prev = tmp;
            }
            return cur;

            //TODO 最牛逼的，直接用斐波那契数列的公式
            double s = Math.Sqrt(5);
            return (int)Math.Floor((Math.Pow((1 + s)/2, n + 1) + Math.Pow((1 - s)/2, n + 1))/s + 0.5);
        }
    }
}
