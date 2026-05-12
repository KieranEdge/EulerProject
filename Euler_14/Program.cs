int start = 1;
int end = 1000000;
int maxSequence = 0;

Dictionary<long, int> knownColdatzSequence = new Dictionary<long, int>();

for (int i = start; i < end; i++)
{
    Console.WriteLine($"Calculating for {i}");
    long nextNumber = i;
    int sequenceLength = 1;
    while (nextNumber != 1)
    {
        if (nextNumber % 2 == 0)
        {
            nextNumber /= 2;
        }
        else
        {
            nextNumber = (nextNumber * 3) + 1;
        }

        if (knownColdatzSequence.ContainsKey(nextNumber))
        {
            sequenceLength = knownColdatzSequence[nextNumber] + sequenceLength;
            break;
        }
        else
        {
            sequenceLength++;
        }
    }

    if (!knownColdatzSequence.ContainsKey(i))
    {
        knownColdatzSequence.Add(i, sequenceLength);
    }
}

long keyOfMaxValue = knownColdatzSequence.MaxBy(x => x.Value).Key;

Console.WriteLine($"Max sequence length = {keyOfMaxValue}");