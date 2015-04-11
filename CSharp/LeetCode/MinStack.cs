using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MinStack
    {
        List<int> list=new List<int>();
        private int min=int.MaxValue;
        public void Push(int x)
        {
            list.Add(x);
            if (x < min)
            {
                min = x;
            }
        }

        public void Pop()
        {
            var c = list.Count-1;
            var p = list[c];
            list.RemoveAt(c);
            if (p == min)
            {
                min = Int32.MaxValue;
                foreach (var i in list)
                {
                    min = Math.Min(min, i);
                }
            }
          
            
        }

        public int Top()
        {
            var c = list.Count - 1;
            var p = list[c];
            return p;
        }

        public int GetMin()
        {
            return min;
        }
    }
}
