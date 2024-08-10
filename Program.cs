using DataStructuresAndAlgorithms.Search;

//CompareIterationVsRecursion.CompareIterationVsRecursionForPrintNumbers(1000);
//CompareIterationVsRecursion.CompareIterationVsRecursionForSumOfNumbers(1000);
//CompareTreeVsTailRecursion.CompareTreeVsTailRecursionForSumOfNumbers(1000);

int randomNumberLength = 5;

Console.Write("Provide the length of the random numbers to generate:");
int.TryParse(Console.ReadLine(), out randomNumberLength);
int[] numbers = RandomNumberGenerator.GenerateRandomNumbers(randomNumberLength);

RandomNumberGenerator.Print(numbers);

int numberToFind = -1;
Console.Write($"Provide a number to find in the random numbers generated between 0 and {randomNumberLength - 1}:");
int.TryParse(Console.ReadLine(), out numberToFind);

LinearSearch.Search(numbers, numberToFind);