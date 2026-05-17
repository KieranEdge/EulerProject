using Euler_22.Helpers;

string filePath = "/Users/kieranedge/RiderProjects/EulerProject/Euler_22/Data.txt";

List<string> sortedListOfNames = DataExtractor.NameExtractorFromFile(filePath);

int runningTotal = 0;

int multiplyingFactor = 1;
foreach (string name in sortedListOfNames)
{
    int wordValue = WordSum.WordScoreValue(name);
    runningTotal += wordValue * multiplyingFactor;
    multiplyingFactor++;
}

Console.WriteLine($"Total word score: {runningTotal}");