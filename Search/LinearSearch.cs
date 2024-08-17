using DataStructuresAndAlgorithms.Helper;

namespace DataStructuresAndAlgorithms.Search
{
    public class LinearSearch
    {
        public static int Search(int[] array, int key)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == key)
                {
                    Console.WriteLine($"{key} found at index {index}");
                    return index;
                }
            }

            Console.WriteLine($"{key} not found!");
            return -1;
        }

        public static void ExecuteSearch()
        {
            int randomNumberLength = UserInterfaceHelper.GetANumberFromUser("Provide the count of the random numbers to generate:");
            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(randomNumberLength);
            UserInterfaceHelper.Print(numbers);
            int numberToFind = UserInterfaceHelper.GetANumberFromUser($"Provide a number to find in the random numbers generated between 1 and {randomNumberLength}:");
            LinearSearch.Search(numbers, numberToFind);
        }       
    }
}