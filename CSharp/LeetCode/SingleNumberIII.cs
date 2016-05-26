using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// todo 这道题知道是异或，但是不知道异或后怎么做了。以下是网上给出的思路：
        /// 基本的思路还是利用位运算，除去出现次数为2次的数。
        /// 如果对所有元素进行异或操作，最后剩余的结果是出现次数为1次的两个数的异或结果，此时无法直接得到这两个数具体的值。
        /// 但是，因为这两个数一定是不同的，所以最终异或的值至少有一个位为1。
        /// 我们可以找出异或结果中第一个值为1的位，然后根据该位的值是否为1，将数组中的每一个数，分成两个部分。
        /// 这样每个部分，就可以采用Sing number I中的方法得到只出现一次的数。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SingleNumber(int[] nums)
        {
            int x = 0;
            foreach (var num in nums)
            {
                x = x ^ num;
            }
            int lastbit = x & (~(x - 1));//todo 这是干啥？拿到最右边那个1
            //Or: xor - (xor & (xor - 1))
            var single = new int[2];
            foreach (int num in nums)
            {
                if ((num & lastbit) != 0)
                {
                    single[0] ^= num;
                }
                else {
                    single[1] ^= num;
                }
            }

            return single;
        }
    }
}
