using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeUT
{
    class SymmetricTreeUT:BaseUT
    {
        [Test]
        public void Test1()
        {
            TreeNode root=new TreeNode(1);
            TreeNode node1=new TreeNode(2);
            TreeNode node2=new TreeNode(2);
            TreeNode node3=new TreeNode(3);
            TreeNode node4=new TreeNode(3);
            TreeNode node5=new TreeNode(4);
            TreeNode node6=new TreeNode(4);
            root.left = node1;
            root.right = node2;
            node1.left = node3;
            node2.right = node4;
            node3.right = node5;
            node4.left = node6;
            var result= Solution.IsSymmetric(root);
            Assert.IsTrue(result);
        }
    }
}
