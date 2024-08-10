using DataStructuresAndAlgorithms.Search;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareLinearSearchBinarySearch
    {
        public static void Compare()
        {
            int randomNumberLength = 5;

            Console.Write("Provide the length of the random numbers to generate:");
            int.TryParse(Console.ReadLine(), out randomNumberLength);
            int[] numbers = RandomNumberGenerator.GenerateSortedRandomNumbers(randomNumberLength);
            RandomNumberGenerator.Print(numbers);

            int numberToFind = -1;
            Console.Write($"Provide a number to find in the random numbers generated between 1 and {randomNumberLength}:");
            int.TryParse(Console.ReadLine(), out numberToFind);

            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2,timeElapsed3;

            start = DateTime.Now;
            LinearSearch.Search(numbers, numberToFind);
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);

            start = DateTime.Now;
            BinarySearchIteration.Search(numbers, numberToFind);
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);


            start = DateTime.Now;
            BinarySearchRecursion.Search(numbers, numberToFind);
            end = DateTime.Now;
            timeElapsed3 = end.Subtract(start);

            Console.WriteLine($"Total Milliseconds for Linear Search: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Binary Search Iterations: {timeElapsed2.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Binary Search Recursions: {timeElapsed3.TotalMilliseconds}");
        }
    }
}