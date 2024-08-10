namespace DataStructuresAndAlgorithms.Search
{
    public class LinearSearch
    {
        public static int Search(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    Console.WriteLine($"{key} found at index {i}");
                    return i;
                }
            }

            Console.WriteLine($"{key} not found!");
            return -1;
        }

        public static void ExecuteSearch()
        {
            int randomNumberLength = 5;

            Console.Write("Provide the length of the random numbers to generate:");
            int.TryParse(Console.ReadLine(), out randomNumberLength);
            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(randomNumberLength);

            RandomNumberGenerator.Print(numbers);

            int numberToFind = -1;
            Console.Write($"Provide a number to find in the random numbers generated between 1 and {randomNumberLength}:");
            int.TryParse(Console.ReadLine(), out numberToFind);

            LinearSearch.Search(numbers, numberToFind);
        }
    }
}