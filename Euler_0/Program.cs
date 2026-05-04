// Getting the sum of all odd square numbers
long sum = 0;
int max = 445000;

for (long i = 1; i <= max; i++)
{
    if (i % 2 != 0)
    {
        sum += i * i;
    }
}

Console.WriteLine(sum);