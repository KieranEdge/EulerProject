using Euler_7.Helper;

int counter =  0;
long number = 2;

while(counter <= 10001)
{
    if (PrimeInformation.IsPrimeNumber(number))
    {
        counter++;
        Console.WriteLine($"The number {counter} prime is {number}");
    }
    number++;
}
