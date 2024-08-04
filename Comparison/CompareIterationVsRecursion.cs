using DataStructuresAndAlgorithms.Iteration;
using Recursions = DataStructuresAndAlgorithms.Recursion;

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

        start = DateTime.Now;
        SumOfNumbers.Calculate(number);
        end = DateTime.Now;
        timeElapsed1 = end.Subtract(start);


        start = DateTime.Now;
        Recursions.SumOfNumbers.Calculate(number);
        end = DateTime.Now;
        timeElapsed2 = end.Subtract(start);

        Console.WriteLine($"Total Milliseconds for Iterations: {timeElapsed1.TotalMilliseconds}");
        Console.WriteLine($"Total Milliseconds for Recursions: {timeElapsed2.TotalMilliseconds}");
    }
}