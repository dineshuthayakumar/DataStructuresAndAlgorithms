namespace DataStructuresAndAlgorithms.Recursion
{
    public class TailRecursion
    {
        public static int Calculate(int number)
        {
            if (number <= 0)
                return 0;

            return number + Calculate(number - 1);
        }
    }
}