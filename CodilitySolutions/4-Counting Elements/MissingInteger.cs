using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    public static class MissingInteger
    {
        public static int solution(int[] A)
        {
            int result = 1;

            HashSet<int> itemCheck = new HashSet<int>();

            foreach (var item in A)
            {
                if (item == result)
                {
                    result++;
                    while (itemCheck.Contains(result))
                    {
                        result++;
                    }
                }
                if (!itemCheck.Contains(item))
                {
                    itemCheck.Add(item);
                }
            }

            return result;
        }
    }
}
/*
 
 Write a function:

    class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [−1,000,000..1,000,000].

 */
