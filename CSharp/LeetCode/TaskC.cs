using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        const int FLAG = Int32.MaxValue;
        public int solution(int[][] A)
        {
            //1UP 2Left 3Down 4Right
          
            if (A.Length == 0) return 0;
            if (A[0].Length == 0) return 0;
            int[][] map = new int[A.Length][];

            int country = 0;
            for (var n = 0; n < A.Length; n++)
            {
                map[n]=new int[A[n].Length];
                for (int m = 0; m < A[0].Length; m++)
                {
                    map[n][m] = FLAG;
                }
            }

            for (var n = 0; n < A.Length; n++)
            {
                for (int m = 0; m < A[0].Length; m++)
                {
                    if (map[n][m] != FLAG)
                        continue;
                    //map[n][m] = country++;
                    PaintCountry(A, map, n, m, country++);//新国家
                }
            }

            return country;
        }

        private void PaintCountry(int[][] A,int[][] map, int n, int m, int flag)
        {
            map[n][m] = flag;
            //up
            if (n > 0)
            {
                if (A[n][m] == A[n - 1][m] && map[n - 1][m]==FLAG)
                {
                    PaintCountry(A, map, n - 1, m, flag);
                }
            }
            //left
            if (m > 0)
            {
                if (A[n][m] == A[n][m - 1] && map[n][m - 1]==FLAG)
                {
                    PaintCountry(A, map, n, m-1, flag);
                }
            }
            //down
            if (n < A.Length - 1)
            {
                if (A[n][m] == A[n + 1][m] && map[n + 1][m] == FLAG)
                {
                    PaintCountry(A, map, n + 1, m, flag);
                }
            }
            //right
            if (m < A[0].Length - 1)
            {
                if (A[n][m] == A[n][m + 1] && map[n][m + 1] == FLAG)
                {
                    PaintCountry(A, map, n, m + 1, flag);
                }
            }
        }

    }
}
