using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    public static class PermCheck
    {
        public static int solution(int[] A)
        {
            int result = 1;

            HashSet<int> itemCheck = new HashSet<int>();

            foreach (var item in A)
            {
                if (item > A.Length || item <= 0 || itemCheck.Contains(item))
                {
                    result = 0;
                    break;
                }
                itemCheck.Add(item);
            }

            return result;
        }
    }
}
