using Problems.Interfaces;
using ProjectEuler.Core.Arithmetic;

namespace Problems.Problems30_60;

public class Problem_39:IProblem
{
    public int ProblemNumber => 39;
    public string Solve()
    {
        // Iterating over the perimeter
        Dictionary<int, int> perimetersAndSolutions = new Dictionary<int, int>();
        List<int> listOfSquareNumbers = Pythagoras.GenerateSquareNumbers(1000);

        for (int p = 5; p <= 1000; p++)
        {
            int solutions = 0;

            for (int a = 1; a < p; a++)
            {
                for (int b = a; b < p; b++)
                {
                    int c = p - a - b;
                    if (c <= 0) break;

                    if (a * a + b * b == c * c)
                    {
                        solutions++;
                    }
                }
            }

            perimetersAndSolutions[p] = solutions;
        }
        int maxKey = perimetersAndSolutions
            .Aggregate((x, y) => x.Value > y.Value ? x : y)
            .Key;
        
        return maxKey.ToString();
    }
    
}