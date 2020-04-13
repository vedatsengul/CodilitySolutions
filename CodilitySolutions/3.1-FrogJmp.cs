using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    public static class FrogJmp
    {
        public static int solution(int X, int Y, int D)
        {
            int distance = Y - X;
            int numberOfJumps = distance / D;

            if (distance % D != 0)
            {
                numberOfJumps++;
            }

            return numberOfJumps;
        }
    }
}
