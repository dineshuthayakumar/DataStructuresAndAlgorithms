using DataStructuresAndAlgorithms.Search;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareLinearSearchBinarySearch
    {
        public static void Compare()
        {
            int[] numbers = RandomNumberGenerator.GenerateSortedRandomNumbers(1000);
            RandomNumberGenerator.Print(numbers);

            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2,timeElapsed3;

            start = DateTime.Now;
            LinearSearch.Search(numbers, 5);
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);

            start = DateTime.Now;
            BinarySearchIteration.Search(numbers, 5);
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);


            start = DateTime.Now;
            BinarySearchRecursion.Search(numbers, 5);
            end = DateTime.Now;
            timeElapsed3 = end.Subtract(start);

            Console.WriteLine($"Total Milliseconds for Linear Search: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Binary Search Iterations: {timeElapsed2.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Binary Search Recursions: {timeElapsed3.TotalMilliseconds}");
        }
    }
}