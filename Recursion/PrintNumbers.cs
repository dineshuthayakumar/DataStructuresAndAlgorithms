namespace DataStructuresAndAlgorithms.Recursion
{
    public class PrintNumbers
    {
        public static void Print(int n)
        {
            if (n == 0)
                return;

            Print(n - 1);
            System.Console.WriteLine(n);
        }
    }
}