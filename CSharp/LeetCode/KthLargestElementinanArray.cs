using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// TODO 这个一个堆排序，我自己想不出来，算法有点复杂，参考：http://www.cnblogs.com/skywang12345/p/3602162.html
        ///  求给定数组的第K大的元素。如果先排序，然后取第K个元素，那么时间复杂度是O(n*log n)。
        /// 借助堆的数据结构，可以把时间复杂度降到O(n*logk)。
        /// 如果求第K大的元素，那么要构建的是小顶堆。求第K小的元素，那么要构建大顶堆！
        /// 先构建k个元素的堆，另外i-k个元素逐个跟堆顶元素比较，
        /// 如果比堆顶元素小，那么就将该元素纳入堆中，并保持堆的性质。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public  int FindKthLargest(int[] nums, int k)
        {
            int[] heap = new int[k];

            heap[0] = nums[0];
            for (int i = 1; i < k; i++)
            {
                siftUp(nums[i], heap, i);
            }

            for (int i = k; i < nums.Length; i++)
            {
                siftDown(nums, k, heap, i);
            }

            return heap[0];
        }

        private  void siftDown(int[] nums, int k, int[] heap, int i)
        {
            if (nums[i] > heap[0])
            {
                heap[0] = nums[i];
                int p = 0;
                while (p < k)
                {
                    int minChild = 2 * p + 1;
                    if (minChild + 1 < k && heap[minChild] > heap[minChild + 1]) minChild++;
                    if (minChild < k && heap[p] > heap[minChild])
                    {
                        swap(heap, p, minChild);
                        p = minChild;
                    }
                    else break;
                }
            }
        }

        private  void siftUp(int num, int[] heap, int i)
        {
            int p = i;
            heap[i] = num;
            while (p != 0)
            {
                int parent = (p - 1) / 2;
                if (heap[parent] > heap[p])
                {
                    swap(heap, p, parent);
                }
                p = parent;
            }
        }

        private  void swap(int[] heap, int p, int parent)
        {
            int temp = heap[parent];
            heap[parent] = heap[p];
            heap[p] = temp;
        }
    }









    //public int FindKthLargest(int[] nums, int k)
    //    {
    //        //初始化堆
    //        int[] b = new int[k];
    //        for (int i = 0; i < k; i++)
    //        {
    //            b[i] = nums[i];
    //        }
    //        //先构建成最小堆
    //        for (int i = b.Length/2; i >= 0; i--)
    //        {
    //            minHeapSort(b, i, b.Length);
    //        }
    //        //交换数据
    //        for (int i = k; i < nums.Length; i++)
    //        {
    //            if (nums[i] > b[0])
    //            {
    //                b[0] = nums[i];
    //                minHeapSort(b, 0, b.Length);
    //            }
    //        }
    //        return b[0];
    //    }

    //    private void minHeapSort(int[] b, int i, int n)
    //    {
    //        int tmp = b[i];
    //        int child;
    //        for (; i*2 + 1 < n; i = child)
    //        {
    //            child = i*2 + 1;
    //            if (child < n - 1 && b[child + 1] < b[child])
    //            {
    //                child++;
    //            }
    //            if (tmp > b[child])
    //            {
    //                b[i] = b[child];
    //            }
    //            else break;
    //        }
    //        b[i] = tmp;
    //    }
    
}
