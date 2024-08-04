namespace DataStructuresAndAlgorithms.Recursion
{
    public class PrintNumbers
    {
        public static void Print(int number)
        {
            if (number <= 0)
                return;

            Print(number - 1);
            System.Console.WriteLine(number);
        }
    }
}