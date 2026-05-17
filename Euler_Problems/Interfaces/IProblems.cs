namespace Problems.Interfaces;

public interface IProblem
{
    int ProblemNumber { get; }
    string Solve();
}