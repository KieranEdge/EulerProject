int start = 1;
int end = 1000000;
int maxSequence = 0;

for (int i = start; i < end; i++)
{
    Console.WriteLine($"Calculating for {i}");
    int nextNumber = i;
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
        sequenceLength++;
    }
    //Console.Write($"{i} has a sequence of {sequenceLength}");
    if(sequenceLength > maxSequence)
    {
        maxSequence = sequenceLength;
    }
}

Console.WriteLine($"Max sequence length = {maxSequence}");