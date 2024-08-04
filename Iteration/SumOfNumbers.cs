namespace DataStructuresAndAlgorithms.Iteration
{
    public class SumOfNumbers
    {
        public static int Calculate(int number)
        {
            int total = 0;
            for (int index = 1; index <= number; index++)
            {
                total += index;
            }
            return total;
        }
    }
}