using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    public static class CyclicRotation
    {
        public static int[] solution(int[] A, int K)
        {
            if (A.Length == 0 || K == 0)
            {
                return A;
            }

            var result = new int[A.Length];

            int shiftCount = K % A.Length;

            for(int i=0;i<A.Length;i++)
            {
                int index = (i + shiftCount) % A.Length;
                result[index] = A[i];
            }

            return result;
        }
    }
}