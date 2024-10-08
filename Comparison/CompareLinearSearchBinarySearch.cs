using DataStructuresAndAlgorithms.Helper;
using DataStructuresAndAlgorithms.Search;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareLinearSearchBinarySearch
    {
        public static void Compare()
        {
            int randomNumberLength = UserInterfaceHelper.GetANumberFromUser("Provide the count of the random numbers to generate:");
            int[] numbers = RandomNumberGenerator.GenerateSortedRandomNumbers(randomNumberLength);
            UserInterfaceHelper.Print(numbers);

            int numberToFind = UserInterfaceHelper.GetANumberFromUser($"Provide a number to find in the random numbers generated between 1 and {randomNumberLength}:");

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

            UserInterfaceHelper.PrintStatistics("Linear Search", timeElapsed1.TotalMilliseconds);
            UserInterfaceHelper.PrintStatistics("Binary Search Iterations", timeElapsed2.TotalMilliseconds);
            UserInterfaceHelper.PrintStatistics("Binary Search Recursions", timeElapsed3.TotalMilliseconds);
        }
    }
}