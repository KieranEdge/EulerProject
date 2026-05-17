int start = 1;
int end = 1000;
int maxReciprocalCycle = 0;

for (int i = start; i <= 1000; i++)
{
    int reciprocalCycleLength = LongDivisionCycleTimeLength(i);
    Console.WriteLine($"1/{i} has reciprocal cycle length of {reciprocalCycleLength}");
    if (reciprocalCycleLength > maxReciprocalCycle)
    {
        maxReciprocalCycle = reciprocalCycleLength;
    }
}
Console.WriteLine($"Max reciprocal cycle is {maxReciprocalCycle}");

static int LongDivisionCycleTimeLength(int denominator)
{
    int numerator = 1;
    List<int> remainders = new List<int>();
    int remainder = numerator % denominator;

    if (remainder == 0)
    {
        return 0;
    }

    while (remainder != 0)
    {
        remainders.Add(remainder);
        numerator = remainder * 10;
        remainder = numerator % denominator;
        if (remainders.Contains(remainder))
        {
            int index = remainders.Count - remainders.IndexOf(remainder);
            return index + 1;
        }
    }

    return 0;
}