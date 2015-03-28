using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeUT
{
    class BalancedBinaryTreeUT:BaseUT
    {
        private TreeNode BuildTree()
        {
            TreeNode root=new TreeNode(0);
            TreeNode n1=new TreeNode(1);
            TreeNode n2=new TreeNode(2);
            TreeNode n3=new TreeNode(3);
            TreeNode n4=new TreeNode(4);
            root.left = n1;
            root.right = n2;
            n1.left = n3;
            n2.right = n4;
            return root;
        }
        [Test]
        public void Test()
        {
            var tree = BuildTree();
            Assert.IsTrue(Solution.IsBalanced(tree));
        }
        [Test]
        public void Test2()
        {
            var tree = BuildTree();
            var n5 = new TreeNode(5);
            var n6 = new TreeNode(6);
            n5.right = n6;
            tree.left.left.left = n5;
            Assert.IsFalse(Solution.IsBalanced(tree));
        }
        [Test]
        public void Test3()
        {
            var tree = new TreeNode(1);
            var n5 = new TreeNode(5);
            tree.right = n5;
            var n6 = new TreeNode(6);
            n5.right = n6;
 
            Assert.IsFalse(Solution.IsBalanced(tree));
        }
    }
}
