namespace DataStructuresAndAlgorithms.Search
{
    public class BinarySearchRecursion
    {
        public static int Search(int[] numbers, int key)
        {
            return Search(numbers, key, 0, numbers.Length - 1);
        }

        private static int Search(int[] numbers, int key, int start, int end)
        {
            if (start >= end)
            {
                Console.WriteLine($"{key} not found!");
                return -1;
            }

            int mid = start + end / 2;

            if (numbers[mid] == key)
            {
                Console.WriteLine($"{key} found at index {mid}");
                return mid;
            }
            else if (key < numbers[mid])
            {
                return Search(numbers, key, start, mid - 1);
            }
            else
            {
                return Search(numbers, key, mid + 1, end);
            }
        }

        public static void ExecuteSearch()
        {
            int randomNumberLength = 5;

            Console.Write("Provide the length of the random numbers to generate:");
            int.TryParse(Console.ReadLine(), out randomNumberLength);
            int[] numbers = RandomNumberGenerator.GenerateSortedRandomNumbers(randomNumberLength);

            RandomNumberGenerator.Print(numbers);

            int numberToFind = -1;
            Console.Write($"Provide a number to find in the random numbers generated between 1 and {randomNumberLength}:");
            int.TryParse(Console.ReadLine(), out numberToFind);

            BinarySearchRecursion.Search(numbers, numberToFind);
        }
    }
    
}
