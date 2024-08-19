using DataStructuresAndAlgorithms.Recursion;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareTreeVsTailRecursion
    {
        public static void CompareTreeVsTailRecursionForSumOfNumbers(int number)
        {
            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2;
            int total1, total2 = 0;

            start = DateTime.Now;
            total1 = TreeRecursion.Calculate(number);
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);


            start = DateTime.Now;
            total2 = TailRecursion.Calculate(number);
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);

            Console.WriteLine($"Total from Tree Recursion: {total1}");
            Console.WriteLine($"Total from Tail Recursion: {total2}");
            Console.WriteLine($"Total Milliseconds for Tree Recursion: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Tail Recursion: {timeElapsed2.TotalMilliseconds}");
        }
    }
}