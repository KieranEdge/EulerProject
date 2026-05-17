using Euler_17.Helpers;

NumberDictionary NumberValueCalculator = new NumberDictionary();
int sum = 0;

for (int i = 0; i <= 1000; i++)
{
    Console.WriteLine(i);
    sum += NumberValueCalculator.ReturnNumberValue(i);
}

Console.WriteLine(sum);