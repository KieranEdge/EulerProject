int min = 1;
int max = 100;

int sumOfNumbers = 0;

// Getting the sum of the range
for (int i = min; i <= max; i++)
{
    sumOfNumbers += i;
}

// Getting the square of this value
long squareOfRangeSum = sumOfNumbers * sumOfNumbers;

// Getting the sum of all the squares
long sumOfIndividualNumbersSquared = 0;

for (int i = min; i <= max; ++i)
{
    sumOfIndividualNumbersSquared += (i * i);
}

// Getting the difference
Console.WriteLine(squareOfRangeSum -  sumOfIndividualNumbersSquared);
