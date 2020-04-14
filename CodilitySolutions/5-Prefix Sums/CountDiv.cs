using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    public static class CountDiv
    {
        public static int solution(int A, int B, int K)
        {
            int result = 0;

            int firstRemainder = A % K;
            int firstDivisible = 0;

            if (firstRemainder == 0)
            {
                firstDivisible = A;
            }
            else
            {
                firstDivisible = A + K - firstRemainder;
            }

            if (firstDivisible > B)
            {
                return 0;
            }

            result = (B - firstDivisible) / K;
            result++;//first divisible
            return result;
        }
    }
}
/*

Write a function:

    class Solution { public int solution(int A, int B, int K); }

that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:

    { i : A ≤ i ≤ B, i mod K = 0 }

For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.

Write an efficient algorithm for the following assumptions:

        A and B are integers within the range [0..2,000,000,000];
        K is an integer within the range [1..2,000,000,000];
        A ≤ B.

 */
