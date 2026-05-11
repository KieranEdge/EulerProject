using Euler_18.Helpers;

string filePath = "/Users/kieranedge/RiderProjects/EulerProject/Euler_18/Data_67.txt";

List<List<int>> rowsOfInts = DataAccessor.TextFileToListOfInts(filePath);

int numOfRows = rowsOfInts.Count;
List<int> mostRecentSum = rowsOfInts[numOfRows - 1];

for (int i = numOfRows - 2; i >= 0; i--)
{
    // List of the max sums
    List<int> maxSumOnRow = new List<int>();
    
    // The sample row (n - 1)
    List<int> samplingRow =  rowsOfInts[i];
    int lengthOfRow = samplingRow.Count;

    for (int j = 0; j < lengthOfRow; j++)
    {
        // Getting the max value of the row index with the two values below it
        int maxValue = Math.Max(samplingRow[j] + mostRecentSum[j], samplingRow[j] + mostRecentSum[j + 1]);
        maxSumOnRow.Add(maxValue);
    }
    mostRecentSum = maxSumOnRow;
}

Console.WriteLine(mostRecentSum[0]);

