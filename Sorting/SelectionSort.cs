using System.Data;
using DataStructuresAndAlgorithms.Helper;
using RandomNumberGenerator = DataStructuresAndAlgorithms.Search.RandomNumberGenerator;

namespace DataStructuresAndAlgorithms.Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] numbers)
        {
            int count = numbers.Length;
            int smallestNumberPosition = -1;
            for(int left = 0; left < count - 1; left++)
            {
                smallestNumberPosition = left;
                for (int right = left + 1; right < count; right++)
                {
                    if (numbers[right] < numbers[smallestNumberPosition])
                    {
                        smallestNumberPosition = right;
                    }
                }
                NumberHelper.Swap(numbers, left, smallestNumberPosition);
            }
        }

        public static void ExecuteSorting()
        {
            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(10);
            UserInterfaceHelper.Print(numbers);
            Sort(numbers);
            UserInterfaceHelper.Print(numbers);
        }
    }
}