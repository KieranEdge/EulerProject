// Initialise the list and return the last value
List<long> fibonacciNumbers = new List<long> { 1, 2, 3 };
long mostRecentNumber = fibonacciNumbers.Last();

while (mostRecentNumber < 4000000)
{
    int listLength = fibonacciNumbers.Count;
    long lastNumber = fibonacciNumbers.Last();
    long numberBefore = fibonacciNumbers[listLength - 2];

    mostRecentNumber = lastNumber + numberBefore;
    if (mostRecentNumber <= 4000000)
    {
        fibonacciNumbers.Add(mostRecentNumber);
    }
}

long sum = 0;
foreach (long number in fibonacciNumbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine(sum);