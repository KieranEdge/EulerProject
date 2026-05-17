List<int> setOfDigits = new List<int>{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
List<int> permutatedOrder = new List<int>();

int permutation = 999999;
int permutationRemainder;
int i = setOfDigits.Count - 1;

while (i >= 0)
{
    // Getting the factorial divisor
    int factorialDivisor = FactorialCalculator(i);
    
    // Getting the index of digit to extract from the set
    int index = permutation / factorialDivisor;
    
    // Assigning the permutation value to the remainder
    permutation = permutation % factorialDivisor;
    
    // Adding the digit to the ordered digits list
    permutatedOrder.Add(setOfDigits[index]);
    
    // Removing the value from the list
    setOfDigits.RemoveAt(index);
    
    i--;
}

Console.WriteLine(string.Join("", permutatedOrder));



static int FactorialCalculator(int n)
{
    int factorial = 1;
    if (n == 0)
    {
        return factorial;
    }
    else
    {
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}