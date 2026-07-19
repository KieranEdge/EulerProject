using System.ComponentModel.Design;
using Problems.Interfaces;
using ProjectEuler.Core.Primes;

namespace Problems.Problems30_60;

public class Problem_47:IProblem
{
    public int ProblemNumber => 47;

    public string Solve()
    {
        long currentNumber = 647;
        int runningCounter = 1;

        while (runningCounter < 4)
        {
            List<long> currentNumberFactors = Factors.PrimeFactors(currentNumber);
            List<long> nextNumberFactors = Factors.PrimeFactors(currentNumber + 1);
            
            if(!ArePrimeFactorsShared(currentNumberFactors, nextNumberFactors))
            {
                runningCounter++;
            }
            else
            {
                runningCounter = 1;
            }

            currentNumber++;
        }

        long finalNumber = currentNumber - 3;
        
        return finalNumber.ToString();
    }

    public bool ArePrimeFactorsShared(List<long> currentNumberFactors, List<long> nextNumberFactors)
    {
        foreach (long factor in currentNumberFactors)
        {
            if(nextNumberFactors.Contains(factor))
            {
                return true;
            }
        }
        return false;
    }
    
}