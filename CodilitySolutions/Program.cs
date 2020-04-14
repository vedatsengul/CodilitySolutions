using System;

namespace CodilitySolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(BinaryGap.solution(561892));
            //var result = CyclicRotation.solution(new int[] { -1, -2, -3, -4, -5, -6 }, 10);
            //Console.WriteLine(OddOccurrencesInArray.solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
            //Console.WriteLine(FrogJmp.solution(5, 105, 3));
            //Console.WriteLine(PermMissingElem.solution(new int[] { 2, 3, 1, 5 }));
            //Console.WriteLine(TapeEquilibrium.solution(new int[] { 3, 1, 2, 4, 3 }));
            //Console.WriteLine(FrogRiverOne.solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));
            //var result = MaxCounters.solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
            //Console.WriteLine(MissingInteger.solution(new int[] { 1, 3, 6, 4, 1, 2 }));
            //Console.WriteLine(PermCheck.solution(new int[] { 4, 1, 3 }));
            //Console.WriteLine(PassingCars.solution(new int[] { 1, 0, 1, 0, 0, 1, 1 }));
            //Console.WriteLine(CountDiv.solution(6, 11, 2));

            var result = GenomicRangeQuery.solution("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 });

            Console.Read();
        }
    }
}
