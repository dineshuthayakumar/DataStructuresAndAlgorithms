namespace DataStructuresAndAlgorithms.Iteration
{
    public class PrintNumbers
    {
        public static void Print(int n)
        {
            //rename variable i to index for better readability and understanding

            for (int index = 1; index <= n; index++)
            {
                System.Console.WriteLine(index);
            }
        }
    }
}