using DataStructuresAndAlgorithms.Iteration;
using Recursions = DataStructuresAndAlgorithms.Recursion;

namespace DataStructuresAndAlgorithms.Comparison
{
    public static class CompareIterationVsRecursion
    {
        public static void CompareIterationVsRecursionForPrintNumbers(int number)
        {
            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2;

            start = DateTime.Now;
            PrintNumbers.Print(number);
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);


            start = DateTime.Now;
            Recursions.PrintNumbers.Print(number);
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);

            Console.WriteLine($"Total Milliseconds for Iterations: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Recursions: {timeElapsed2.TotalMilliseconds}");
        }

        public static void CompareIterationVsRecursionForSumOfNumbers(int number)
        {
            DateTime start, end;
            TimeSpan timeElapsed1, timeElapsed2;
            int total1, total2 = 0;

            start = DateTime.Now;
            total1 = SumOfNumbers.Calculate(number);
            end = DateTime.Now;
            timeElapsed1 = end.Subtract(start);


            start = DateTime.Now;
            total2 = Recursions.SumOfNumbers.Calculate(number);
            end = DateTime.Now;
            timeElapsed2 = end.Subtract(start);

            Console.WriteLine($"Total from Iterations: {total1}");
            Console.WriteLine($"Total from Iterations: {total2}");
            Console.WriteLine($"Total Milliseconds for Iterations: {timeElapsed1.TotalMilliseconds}");
            Console.WriteLine($"Total Milliseconds for Recursions: {timeElapsed2.TotalMilliseconds}");
        }
    }
}