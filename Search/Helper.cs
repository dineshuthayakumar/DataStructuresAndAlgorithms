namespace DataStructuresAndAlgorithms.Search
{
    public class RandomNumberGenerator
    {
        public static int[] GenerateRandomNumbers(int count)
        {
            int[] numbers = new int[count];
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(0, count);
            }

            return numbers;
        }

        public static void Print(int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                System.Console.Write($"{i}\t");
            }

            System.Console.WriteLine();

            for (int i = 0; i < number.Length; i++)
            {
                System.Console.Write($"{number[i]}\t");
            }

            System.Console.WriteLine();
        } 
    }
}