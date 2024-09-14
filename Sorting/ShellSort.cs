using DataStructuresAndAlgorithms.Helper;

namespace DataStructuresAndAlgorithms.Sorting
{
    public class ShellSort
    {
        public static void Sort(int[] numbers)
        {
            int count = numbers.Length;
            for (int gap = count / 2; gap > 0; gap /= 2)
            {
                for(int right = gap; right < count; right++)
                {
                    int currentNumber = numbers[right];
                    int left = right;

                    for (; left >= gap && numbers[left - gap] >  currentNumber; left -= gap)
                    {
                        numbers[left]  = numbers[left - gap];
                    }
                    numbers[left] = currentNumber;
                }
            }
        }

        public static void ExecuteSorting()
        {
            int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(11);
            UserInterfaceHelper.Print(numbers);
            Sort(numbers);
            UserInterfaceHelper.Print(numbers);
            UserInterfaceHelper.PrintSortedStatus(NumberHelper.IsSorted(numbers));
        }
    }
}