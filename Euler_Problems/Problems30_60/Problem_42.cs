using Problems.Interfaces;

namespace Problems.Problems30_60;

public class Problem_42:IProblem
{
    public int ProblemNumber => 42;

    public string Solve()
    {
        string filePath = "/Users/kieranedge/RiderProjects/EulerProject/Euler_Problems/Data/Problem_42.txt";
        string[] words = StringsInTextFile(filePath);

        List<int> wordScores = [];
        foreach (string word in words)
        {
            wordScores.Add(WordScore(word));
        }
        
        List<int> triangleNumbers = ListOfTriangles(wordScores.Max());
        int wordsWithTriangleValues = 0;
        foreach (int score in wordScores)
        {
            if (triangleNumbers.Contains(score))
            {
                wordsWithTriangleValues++;
            }
        }
        
        return wordsWithTriangleValues.ToString();
    }

    public List<int> ListOfTriangles(int max)
    {
        List<int> triangleNumbers = new List<int>();
        int currentTriangleNumber = 1;
        int index = 1;
        
        while (currentTriangleNumber <= max)
        {
            triangleNumbers.Add(currentTriangleNumber);
            currentTriangleNumber = (index * (index + 1)) / 2;
            index++;
        }
        
        return triangleNumbers;
    }

    public string[] StringsInTextFile(string filePath)
    {
        string rawFileString = File.ReadAllText(filePath);
        string[] words = rawFileString.Split(" ");
        return words;
    }

    public int WordScore(string word)
    {
        int score = 0;
        char[] letters = word.ToCharArray();
        foreach (char c in letters)
        {
            score += c - 64;
        }
        return score;
    }
}