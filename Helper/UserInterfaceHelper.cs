namespace DataStructuresAndAlgorithms.Helper
{
    public static class UserInterfaceHelper
    {
        public static int GetANumberFromUser(string message)
        {
            Console.Write(message);
            int.TryParse(Console.ReadLine(), out int number);
            return number;
        }
    }
}