namespace DataStructuresAndAlgorithms.Search
{
    public class LinearSearch
    {
        public static int Search(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    Console.WriteLine($"{key} found at index {i}");
                    return i;
                }
            }

            Console.WriteLine($"{key} not found!");
            return -1;
        }
    }
}