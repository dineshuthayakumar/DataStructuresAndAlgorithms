namespace DataStructuresAndAlgorithms.Helper {
    public static class NumberHelper {
        public static void Swap(int[] numbers, int number1Index, int number2Index)
        {
            int temp = numbers[number1Index];
            numbers[number1Index] = numbers[number2Index];
            numbers[number2Index] = temp;
        }
    }
}