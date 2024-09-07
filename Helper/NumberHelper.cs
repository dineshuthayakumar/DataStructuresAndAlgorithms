namespace DataStructuresAndAlgorithms.Helper {
    public static class NumberHelper {
        public static void Swap(int[] numbers, int number1Index, int number2Index)
        {
            int temp = numbers[number1Index];
            numbers[number1Index] = numbers[number2Index];
            numbers[number2Index] = temp;
        }

        public static bool IsSorted(int[] numbers)
        {
            bool isSorted = true;
            for (int index = 1; index < numbers.Length; index++)
            {
                if(numbers[index-1] > numbers[index])
                {
                    Console.WriteLine($"{numbers[index-1]} & {numbers[index]}");
                    isSorted = false;
                    break;
                }
            }
            return isSorted;
        }
    }
}