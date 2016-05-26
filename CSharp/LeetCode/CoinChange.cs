using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// 动态规划法，算出从1元到amount元的最小硬币数
        /// 对于任意Amount，对每种面额循环做如下操作：
        ///                                 拿来减去当前面额，
        ///                                 查询剩下的面额的最小组合，
        ///                                 这个最小组合数+1（当前面额）就是一种组合
        /// 循环后再找出循环中最小的那个组合
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CoinChange(int[] coins, int amount)
        {
            if (amount < 0) return -1;
            if (amount == 0) return 0;
            if (coins == null || coins.Length == 0) return -1;
            int[] dp = new int[amount + 1];
            for (int i = 1; i <= amount; i++)
            {
                int min = Int32.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    var coin = coins[j];
                    
                    if (i >= coin && dp[i - coin] != -1)
                    {
                        min = Math.Min(min, dp[i - coin] + 1);
                    }
                }
                // 根据min的值判断是否能兑换
                dp[i] = min == Int32.MaxValue ? -1 : min;
            }
            return dp[amount];
        }
    }
}
