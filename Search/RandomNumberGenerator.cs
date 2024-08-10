namespace DataStructuresAndAlgorithms.Search
{
    public class RandomNumberGenerator
    {
        public static int[] GenerateRandomNumbers(int count)
        {
            int[] numbers = new int[count];
            Random random = new Random();

            for (int index = 0; index < count; index++)
            {
                numbers[index] = random.Next(1, count);
            }

            return numbers;
        }

        public static void Print(int[] number)
        {
            System.Console.WriteLine("Index");
            for (int index = 0; index < number.Length; index++)
            {
                System.Console.Write($"{index}\t");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Numbers");

            for (int index = 0; index < number.Length; index++)
            {
                System.Console.Write($"{number[index]}\t");
            }

            System.Console.WriteLine();
        } 
    }
}