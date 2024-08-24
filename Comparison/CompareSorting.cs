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
            
            int[] numbers = FileHelper.ReadFile();

            start = DateTime.Now;
            numbers.OrderBy(number => number).ToArray();
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);


            numbers = FileHelper.ReadFile();
            start = DateTime.Now;
            SelectionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);

            numbers = FileHelper.ReadFile();
            start = DateTime.Now;
            InsertionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed3 = end.Subtract(start);

            numbers = FileHelper.ReadFile();
            start = DateTime.Now;
            BubbleSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed4 = end.Subtract(start);


            UserInterfaceHelper.PrintStatistics(".Net Order By", timeElapsed1.TotalMilliseconds);
            UserInterfaceHelper.PrintStatistics("Selection Sort", timeElapsed2.TotalMilliseconds);
            UserInterfaceHelper.PrintStatistics("Insertion Sort", timeElapsed3.TotalMilliseconds);
            UserInterfaceHelper.PrintStatistics("Bubble Sort", timeElapsed4.TotalMilliseconds);
        }
    }
}