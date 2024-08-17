using DataStructuresAndAlgorithms.Helper;
using DataStructuresAndAlgorithms.Iteration;
using DataStructuresAndAlgorithms.Sorting;
using RandomNumberGenerator = DataStructuresAndAlgorithms.Search.RandomNumberGenerator;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareSorting
    {
        public static void CompareAll()
        {
            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2;

            start = DateTime.Now;
            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(100000);
            SelectionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);


            start = DateTime.Now;
            end = DateTime.Now;
            numbers = RandomNumberGenerator.GenerateSortedRandomNumbers(100000);
            timeElapsed2 = end.Subtract(start);

            Console.WriteLine($"Total Milliseconds for Selection Sort: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for .Net Order By: {timeElapsed2.TotalMilliseconds}");
        }
    }
}