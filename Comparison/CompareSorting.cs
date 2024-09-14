using DataStructuresAndAlgorithms.Helper;
using DataStructuresAndAlgorithms.Sorting;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareSorting
    {
        public static void CompareAll()
        {
            DateTime start, end;
            TimeSpan timeElapsed;
            
            int[] numbers = FileHelper.ReadFile();

            start = DateTime.Now;
            numbers = numbers.OrderBy(number => number).ToArray();
            end = DateTime.Now;
            timeElapsed = end.Subtract(start);
            UserInterfaceHelper.PrintStatistics(".Net Order By", timeElapsed.TotalMilliseconds);
            UserInterfaceHelper.PrintSortedStatus(NumberHelper.IsSorted(numbers));


            numbers = FileHelper.ReadFile();
            start = DateTime.Now;
            SelectionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed = end.Subtract(start);
            UserInterfaceHelper.PrintStatistics("Selection Sort", timeElapsed.TotalMilliseconds);
            UserInterfaceHelper.PrintSortedStatus(NumberHelper.IsSorted(numbers));

            numbers = FileHelper.ReadFile();
            start = DateTime.Now;
            InsertionSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed = end.Subtract(start);
            UserInterfaceHelper.PrintStatistics("Insertion Sort", timeElapsed.TotalMilliseconds);
            UserInterfaceHelper.PrintSortedStatus(NumberHelper.IsSorted(numbers));

            numbers = FileHelper.ReadFile();
            start = DateTime.Now;
            BubbleSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed = end.Subtract(start);
            UserInterfaceHelper.PrintStatistics("Bubble Sort", timeElapsed.TotalMilliseconds);
            UserInterfaceHelper.PrintSortedStatus(NumberHelper.IsSorted(numbers));

            numbers = FileHelper.ReadFile();
            start = DateTime.Now;
            ShellSort.Sort(numbers);
            end = DateTime.Now;
            timeElapsed = end.Subtract(start);
            UserInterfaceHelper.PrintStatistics("Shell Sort", timeElapsed.TotalMilliseconds);
            UserInterfaceHelper.PrintSortedStatus(NumberHelper.IsSorted(numbers));
        }
    }
}