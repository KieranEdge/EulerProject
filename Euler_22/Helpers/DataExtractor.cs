namespace Euler_22.Helpers;

public class DataExtractor
{
    public static List<string> NameExtractorFromFile(string path)
    {
        string rawData = File.ReadAllText(path);
        List<string> namesArray = rawData.Split(" ").ToList();
        namesArray.Sort();
        return namesArray;
    }
}