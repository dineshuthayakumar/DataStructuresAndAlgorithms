using System.Data;
using System.Security.Cryptography;
using DataStructuresAndAlgorithms.Search;
using RandomNumberGenerator = DataStructuresAndAlgorithms.Search.RandomNumberGenerator;

namespace DataStructuresAndAlgorithms.Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] numbers)
        {
            int count = numbers.Length;
            int position = -1;
            for(int left = 0; left < count - 1; left++)
            {
                position = left;
                for(int right = left + 1; right < count; right++)
                {
                    if(numbers[right] < numbers[position])
                    {
                        position = right;
                    }
                }

                int temp = numbers[left];
                numbers[left] = numbers[position];
                numbers[position] = temp;
            }      
        }

        public static void ExecuteSorting()
        {
            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(10);
            RandomNumberGenerator.Print(numbers);
            Sort(numbers);
            RandomNumberGenerator.Print(numbers);
        }
    }
}