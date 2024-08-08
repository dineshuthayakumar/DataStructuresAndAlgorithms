namespace DataStructuresAndAlgorithms.Recursion
{
    public class TreeRecursion
    {
        private static int Calculate(int start, int end)
        {
            int total = 0;
            
            if (start == end)
                return start;
            else if (start < end)
            {
                int mid = (start + end) / 2;
                total += Calculate(start, mid);
                total += Calculate(mid + 1, end);
            }

            return total;
        }

        public static int Calculate(int number)
        {
            return Calculate(1, number);
        }
    }
}
