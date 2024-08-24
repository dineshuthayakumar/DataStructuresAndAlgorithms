namespace DataStructuresAndAlgorithms.Helper {
    public static class FileHelper {
        public static void WriteFile(int[] numbers)
        {
            string csvNumbers = string.Join(", ", numbers);
            File.WriteAllText("Numbers.csv", csvNumbers);
        }

        public static int[] ReadFile()
        {
            string csvNumbers = File.ReadAllText("Numbers.csv");
            int[] number = csvNumbers.Split(new[] { ", " }, StringSplitOptions.None)
                                     .Select(int.Parse)
                                     .ToArray();
            return number;
        }
    }
}