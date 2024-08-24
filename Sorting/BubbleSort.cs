using DataStructuresAndAlgorithms.Helper;

namespace DataStructuresAndAlgorithms.Sorting;

public class BubbleSort {
    public static void Sort(int[] numbers)
    {
        int count = numbers.Length;
       for(int left = 0; left < count - 1; left++)
        {
            bool swappedAtleastOnce = false;
            for (int right = left + 1; right < count; right++)
            {
                if(numbers[left] > numbers[right])
                {
                    NumberHelper.Swap(numbers, left, right);
                    swappedAtleastOnce = true;
                }
            }

            if(swappedAtleastOnce == false)
            break;
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