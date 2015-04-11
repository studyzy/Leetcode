using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
   
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/path-sum/
        /// 加入hasValue是为了加快速度，如果搜索到了有结果，那么接下来就不需要再继续搜索了
        /// </summary>
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            if (hasValue)
            {
                return true;
            }
            if (root.left == null && root.right == null)
            {
                hasValue= root.val == sum;
                return hasValue;
            }
            bool isLeft = false;
            bool isRight = false;
            if (root.left != null) isLeft = HasPathSum(root.left, sum - root.val);
            if (root.right != null) isRight = HasPathSum(root.right, sum - root.val);
            return isLeft || isRight;
        }

        private bool hasValue = false;

    }
}
