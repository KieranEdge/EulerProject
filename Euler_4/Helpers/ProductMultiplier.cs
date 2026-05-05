using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4.Helpers
{
    public static class ProductMultiplier
    {
        public static List<int> ReturnProductsInRange(int start, int end)
        {
            List<int> products = new List<int>();

            for(int i = start; i <= end; i++)
            {
                for(int j = i; j <= end; j++)
                {
                    products.Add(i * j);
                }
            }
            List<int> distinctProducts = products.Distinct().ToList();

            return distinctProducts;
        }
    }
}
