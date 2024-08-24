using DataStructuresAndAlgorithms.Helper;

namespace DataStructuresAndAlgorithms.Sorting;

public class InsertionSort {
    public static void Sort(int[] numbers)
    {
        int count = numbers.Length;
        for(int right = 1; right < count; right++)
        {
            int currentNumber = numbers[right];
            int left = right - 1;
            while (left >= 0 &&  numbers[left] >  currentNumber)
            {
               numbers[left + 1]  = numbers[left];
               left--;
            }
            numbers[left + 1] = currentNumber;
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