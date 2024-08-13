using DataStructuresAndAlgorithms.Helper;

namespace DataStructuresAndAlgorithms.Search
{
    public class BinarySearchRecursion
    {
        public static int Search(int[] numbers, int key)
        {
            return Search(numbers, key, 0, numbers.Length - 1);
        }

        public static int Search(int[] numbers, int key, int start, int end)
        {
            if (start > end)
            {
                Console.WriteLine($"{key} not found!");
                return -1;
            }

            int mid = (start + end) / 2;

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
           int randomNumberLength = UserInterfaceHelper.GetANumberFromUser("Provide the count of the random numbers to generate:");
            int[] numbers = RandomNumberGenerator.GenerateSortedRandomNumbers(randomNumberLength);
            RandomNumberGenerator.Print(numbers);
            int numberToFind = UserInterfaceHelper.GetANumberFromUser($"Provide a number to find in the random numbers generated between 1 and {randomNumberLength}:");

            BinarySearchRecursion.Search(numbers, numberToFind);
        }
    }
    
}
