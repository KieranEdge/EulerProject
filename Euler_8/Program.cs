using Euler_8.Helpers;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\CSCourse\\ProjectEuler\\Euler_8\\Data.txt";

// Getting the data as a list of ints
List<int> ints = DataExtractor.TextFileToArrayOfInts(filePath);
int length = ints.Count;
long maxProduct = 0;

Console.WriteLine($"Numeber of integers in file = {length}");

for (int i = 0; i + 13 <= length; i++)
{
    Console.WriteLine(i);
    List<int> subListOfInts = ints.GetRange(i, 13);
    long product = 1;
    foreach(int subInt in subListOfInts)
    {
        product *= subInt;
    }

    if (product > maxProduct)
    {
        maxProduct = product;
    }

}

Console.WriteLine(maxProduct);