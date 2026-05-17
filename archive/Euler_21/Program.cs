using Euler_21.Helpers;

List<int> amicableNumbers = new List<int>();

for(int a = 1; a < 10000; a++)
{
    // Sum of divisors of a
    int b = Divisors.ReturnSumOfDivisors(a);
    
    // Sum of divisors of b
    int c = Divisors.ReturnSumOfDivisors(b);

    if (a == c && a != b)
    {
        Console.WriteLine($"{a} and {b} are amicable numbers");
        amicableNumbers.Add(a);
        amicableNumbers.Add(b);
    }
}

List<int> distinctAmicableNumbers = amicableNumbers.Distinct().ToList();
Console.WriteLine($"The sum of amicable numbers is: {distinctAmicableNumbers.Sum()}");