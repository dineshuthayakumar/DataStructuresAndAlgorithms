using DataStructuresAndAlgorithms.Comparison;
using DataStructuresAndAlgorithms.Helper;
using DataStructuresAndAlgorithms.Iteration;

namespace DataStructuresAndAlgorithms.Helper
{
    public static class MenuHelper
    {
        public static void PrintMainMenu()
        {
            do {
                PrintMenuHeader("Main Menu");
                System.Console.WriteLine("1. Print Numbers");
                System.Console.WriteLine("2. Sum of Numbers");
                System.Console.WriteLine("3. Search");
                System.Console.WriteLine("4. Sorting");
                System.Console.WriteLine("9. Exit");
                int choice = UserInterfaceHelper.GetANumberFromUser("Provide your choice:");
                switch (choice)
                {
                    case 1:
                        PrintNumbersMenu();
                        break;
                    case 2:
                        PrintSumOfNumbersMenu();
                        break;
                    case 3:
                        PrintSearchMenu();
                        break;
                    case 4:
                        PrintSortingMenu();
                        break;
                    case 9:
                        return;
                    default: 
                        PrintInvalidChoice();
                        break;
                }
            } while (true);
        }

        public static void PrintNumbersMenu()
        {
            do {
                PrintMenuHeader("Print Numbers Menu");
                System.Console.WriteLine("1. Compare Iteration vs Recursion for Print Numbers");
                System.Console.WriteLine("2. Back");
                int choice = UserInterfaceHelper.GetANumberFromUser("Provide your choice:");
                switch (choice)
                {
                    case 1:
                        CompareIterationVsRecursion.CompareIterationVsRecursionForPrintNumbers(1000);
                        break;
                    case 2:
                        return;
                    default: 
                        PrintInvalidChoice();
                        break;
                }
            } while (true);
        }
        
        public static void PrintSumOfNumbersMenu()
        {
            do {
                PrintMenuHeader("Sum of Numbers Menu");
                System.Console.WriteLine("1. Compare Iteration vs Recursion for Sum of Numbers");
                System.Console.WriteLine("2. Compare Tree Recursion vs Tail Recursion for Sum of Numbers");
                System.Console.WriteLine("3. Back");
                int choice = UserInterfaceHelper.GetANumberFromUser("Provide your choice:");
                switch (choice)
                {
                    case 1:
                        CompareIterationVsRecursion.CompareIterationVsRecursionForSumOfNumbers(1000);
                        break;
                    case 2:
                        CompareTreeVsTailRecursion.CompareTreeVsTailRecursionForSumOfNumbers(1000);
                        break;
                    case 3:
                        return;
                    default: 
                        PrintInvalidChoice();
                        break;
                }
            } while (true);
        }

        public static void PrintSearchMenu()
        {
            do {
                PrintMenuHeader("Search Menu");
                System.Console.WriteLine("1. Linear Search");
                System.Console.WriteLine("2. Binary Search Iteration vs Recursion");
                System.Console.WriteLine("3. Back");
                int choice = UserInterfaceHelper.GetANumberFromUser("Provide your choice:");
                switch (choice)
                {
                    case 1:
                        CompareLinearSearchBinarySearch.Compare();
                        break;

                    case 2:
                        CompareLinearSearchBinarySearch.Compare();
                        break;

                    case 3:
                        return;
                    default: 
                        PrintInvalidChoice();
                        break;
                }
            } while (true);
        }

        public static void PrintSortingMenu()
        {
            do {
                PrintMenuHeader("Sorting Menu");
                System.Console.WriteLine("1. Compare All");
                System.Console.WriteLine("2. Back");
                int choice = UserInterfaceHelper.GetANumberFromUser("Provide your choice:");
                switch (choice)
                {
                    case 1:
                        CompareSorting.CompareAll();
                        break;
                    case 2:
                        return;
                    default: 
                        PrintInvalidChoice();
                        break;
                }
            }while(true);
        }

        private static void PrintInvalidChoice()
        {
            System.Console.WriteLine("Invalid choice. Please try again.");
        }

        private static void PrintMenuHeader(string menuHeader)
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine($"\t{menuHeader}");
            System.Console.WriteLine("-----------------------------------");
        }
    }
}