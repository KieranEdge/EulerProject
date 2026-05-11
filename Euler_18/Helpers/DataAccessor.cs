namespace Euler_18.Helpers;

public class DataAccessor
{
    public static List<List<int>> TextFileToListOfInts(string filePath)
    {
        List<List<int>> intRows = new List<List<int>>();
        string[] linesInFile = File.ReadAllLines(filePath);
        
        foreach (string line in linesInFile)
        {
            List<int> intsOnRow = new List<int>();
            
            string[] intStringsInLine = line.Split(' ');
            
            foreach (string intString in intStringsInLine)
            {
                intsOnRow.Add(int.Parse(intString));
            }
            intRows.Add(intsOnRow);
        }
        return intRows;
    }
}