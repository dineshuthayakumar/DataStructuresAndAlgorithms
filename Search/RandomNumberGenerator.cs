namespace DataStructuresAndAlgorithms.Search
{
    public class RandomNumberGenerator
    {
        public static int[] GenerateRandomNumbers(int count)
        {
            List<int> numberList = new List<int>();
            int[] numbers = new int[count];
            Random random = new Random();

            for (int index = 0; index < count;)
            {
                int randomNumber = random.Next(1, int.MaxValue);
                if (numberList.Contains(randomNumber))
                {
                    continue;
                }
                else
                {
                    numberList.Add(randomNumber);
                    numbers[index] = randomNumber;
                    index++;
                }
            }

            return numbers;
        }

        public static int[] GenerateSortedRandomNumbers(int count)
        {
            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(count);
            return numbers.OrderBy(number => number).ToArray();
        }

        public static void Print(int[] numbers)
        {
            System.Console.WriteLine("Index");
            for (int index = 0; index < numbers.Length; index++)
            {
                System.Console.Write($"{index}\t");
            }

            System.Console.WriteLine();
            System.Console.WriteLine($"Numbers: {numbers.Length}");

            for (int index = 0; index < numbers.Length; index++)
            {
                System.Console.Write($"{numbers[index]}\t");
            }

            System.Console.WriteLine();
        } 
    }
}