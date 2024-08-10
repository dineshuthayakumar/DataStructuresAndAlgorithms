namespace DataStructuresAndAlgorithms.Search
{
    public class BinarySearchIteration
    {
        public static int Search(int[] array, int key)
        {
            int start = 0;
            int end = array.Length - 1;
            int mid = (start + end) / 2;

            while(start < end)
            {
                if (array[mid] == key)
                {
                    Console.WriteLine($"{key} found at index {mid}");
                    return mid;
                }
                else if (key < array[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                 mid = (start + end) / 2;
            }

            Console.WriteLine($"{key} not found!");
            return -1;
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

            BinarySearchIteration.Search(numbers, numberToFind);
        }
    }
}
