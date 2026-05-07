using Euler_11.Helpers;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\CSCourse\\ProjectEuler\\Euler_11\\Data.txt";

int[,] intArray = DataAccessor.TextFileToArrayOfInts(filePath);
int numRows = intArray.GetLength(0);
int numCols  = intArray.GetLength(1);

int maxProduct = 0;

for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numCols; j++)
    {
        int maxProductFromPosition = ProductFunctions.MaxSumInAllDirections(intArray, i, j);
        if (maxProductFromPosition > maxProduct)
        {
            maxProduct = maxProductFromPosition;
        }
    }
}
Console.WriteLine(maxProduct);