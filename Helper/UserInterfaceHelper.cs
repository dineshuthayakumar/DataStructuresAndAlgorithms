using System.Globalization;

namespace DataStructuresAndAlgorithms.Helper
{
    public static class UserInterfaceHelper
    {
        public static int GetANumberFromUser(string message)
        {
            Console.Write(message);
            int.TryParse(Console.ReadLine(), out int number);
            return number;
        }

        public static void Print(int[] numbers)
        {
            NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
            System.Console.WriteLine("Index");
            for (int index = 0; index < numbers.Length; index++)
            {
                System.Console.Write($"{index.ToString("N00", nfi)}\t");
            }

            System.Console.WriteLine();
            System.Console.WriteLine($"Numbers: {numbers.Length}");

            for (int index = 0; index < numbers.Length; index++)
            {
                System.Console.Write($"{numbers[index].ToString("N00", nfi)}\t");
            }

            System.Console.WriteLine();
        }

        public static void PrintStatistics(string message, double number)
        {
            NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
            Console.WriteLine($"Total Milliseconds - {message}: {number.ToString("N2", nfi)}");
        } 

        public static void PrintSortedStatus(bool isSorted)
        {
            NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
            Console.WriteLine($"Sorted Status - {isSorted}");
        } 
    }
}