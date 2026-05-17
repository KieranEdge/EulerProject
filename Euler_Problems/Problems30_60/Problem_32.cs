using Problems.Interfaces;
 
 namespace Problems.Problems30_60;
 public class Problem_32 : IProblem
 {
     public int ProblemNumber => 32;

     public string Solve()
     {
         HashSet<int> products = new();

         for (int i = 1; i < 100; i++)
         {
             for (int j = i; j < 10000 / i; j++)
             {
                 int product = i * j;

                 if (IsPandigital(i, j, product))
                     products.Add(product);
             }
         }

         return products.Sum().ToString();
     }

     private bool IsPandigital(int a, int b, int c)
     {
         string s = $"{a}{b}{c}";

         if (s.Length != 9) return false;

         for (char ch = '1'; ch <= '9'; ch++)
         {
             if (s.Count(x => x == ch) != 1)
                 return false;
         }

         return true;
     }
 }