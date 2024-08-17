using System.Globalization;

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
    }
}