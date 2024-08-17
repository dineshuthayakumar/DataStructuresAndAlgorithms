using DataStructuresAndAlgorithms.Helper;
using DataStructuresAndAlgorithms.Iteration;
using DataStructuresAndAlgorithms.Sorting;
using RandomNumberGenerator = DataStructuresAndAlgorithms.Search.RandomNumberGenerator;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareSorting
    {
        public static void CompareAll(int countOfNumbers)
        {
            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2;

            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(countOfNumbers);

            start = DateTime.Now;
            SelectionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);


            numbers = RandomNumberGenerator.GenerateRandomNumbers(countOfNumbers);
            start = DateTime.Now;
            numbers.OrderBy(number => number).ToArray();
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);

            Console.WriteLine($"Total Milliseconds for Selection Sort: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for .Net Order By: {timeElapsed2.TotalMilliseconds}");
        }
    }
}