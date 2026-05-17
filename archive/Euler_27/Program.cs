using Euler_27.Helpers;
int maxPrimeSequenceGlobal = 0;
int bestA = 0;
int bestB = 0;

for (int a = -999; a <= 999; a++)
{
    for (int b = -1000; b <= 1000; b++)
    {
        int n = 0;

        while (PrimeHelper.IsPrimeNumber(
                   QuadraticFormula.QuadraticFormulaValue(n, a, b)))
        {
            n++;
        }

        if (n > maxPrimeSequenceGlobal)
        {
            maxPrimeSequenceGlobal = n;
            bestA = a;
            bestB = b;
        }
    }
}

Console.WriteLine(bestA * bestB);