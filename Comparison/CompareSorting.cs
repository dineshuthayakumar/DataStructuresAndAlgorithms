using DataStructuresAndAlgorithms.Helper;
using DataStructuresAndAlgorithms.Sorting;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareSorting
    {
        public static void CompareAll(int countOfNumbers)
        {
            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2, timeElapsed3, timeElapsed4;

            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(countOfNumbers);

            start = DateTime.Now;
            numbers.OrderBy(number => number).ToArray();
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);


            numbers = RandomNumberGenerator.GenerateRandomNumbers(countOfNumbers);
            start = DateTime.Now;
            SelectionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);

            numbers = RandomNumberGenerator.GenerateRandomNumbers(countOfNumbers);
            start = DateTime.Now;
            InsertionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed3 = end.Subtract(start);

            numbers = RandomNumberGenerator.GenerateRandomNumbers(countOfNumbers);
            start = DateTime.Now;
            BubbleSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed4 = end.Subtract(start);


            Console.WriteLine($"Total Milliseconds for .Net Order By: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Selection Sort: {timeElapsed2.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Insertion Sort: {timeElapsed3.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Bubble Sort: {timeElapsed4.TotalMilliseconds}");
        }
    }
}