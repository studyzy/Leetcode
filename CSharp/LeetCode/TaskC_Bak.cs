using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        public int solution_bak(int[][] A)
        {
            const int FLAG=Int32.MaxValue;
            if (A.Length == 0) return 0;
            if (A[0].Length == 0) return 0;
            int[][] map = new int[A.Length][];
            
            int country = 1;
            for (var n = 0; n < A.Length; n++)
            {
                map[n]=new int[A[n].Length];
                for (int m = 0; m < A[0].Length; m++)
                {
                    map[n][m] = FLAG;
                    //up
                    if (n > 0)
                    {
                        if (A[n][m] == A[n - 1][m])
                        {
                            map[n][m] = map[n - 1][m];
                        }
                    }
                    //left
                    if (m > 0)
                    {
                        if (A[n][m] == A[n][m - 1])
                        {
                            map[n][m] = map[n][m - 1];
                        }
                    }
                    if (map[n][m] == FLAG)
                    {
                        map[n][m] = country++;
                    }
                }
            }
            return country;
        }

        public void PaintCountry(int[][] A, int n, int m,int countryId)
        {
            
        }
    }
}
