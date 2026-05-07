using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_11.Helpers
{
    internal class ProductFunctions
    {
        public static int MaxSumInAllDirections(int[,] intArray, int row, int col)
        { 
            List<int> listOfProducts = new List<int>();

            listOfProducts.Add(TopToBottomSum(intArray, row, col));
            listOfProducts.Add(LeftToRightSum(intArray, row, col));
            listOfProducts.Add(RightDownDiagonalSum(intArray, row, col));
            listOfProducts.Add(LeftDownDiagonalSum(intArray, row, col));

            return listOfProducts.Max();
        }
        public static int TopToBottomSum(int[,] intArray, int row, int col)
        {
            int product = 1;

            // Checking if the top down product is within bounds
            if (row + 3 < intArray.GetLength(0)) 
            {
                // Going row by row to get the product
                for (int i = row; i <= row + 3; i++)
                {
                    product *= intArray[i, col];
                }
            }
            return product;
        }

        public static int LeftToRightSum(int[,] intArray, int row, int col)
        {
            int product = 1;

            // Checking if the left right product is within bounds
            if (col + 3 < intArray.GetLength(1))
            {
                // Going col by col to get the product
                for (int i = col; i <= col + 3; i++)
                {
                    product *= intArray[row, i];
                }
            }

            return product;
        }

        public static int RightDownDiagonalSum(int[,] intArray, int row, int col)
        {
            int product = 1;

            // Checking the right down diagonal is within bounds
            if (row + 3 < intArray.GetLength(0) && col + 3 < intArray.GetLength(1))
            {
                for(int i = row; i <= row + 3; i++)
                {
                    product *= intArray[i, col + (i - row)];
                }
            }

            return product;
        }

        public static int LeftDownDiagonalSum(int[,] intArray, int row, int col)
        {
            int product = 1;

            // Checking the left down diagonal is within bounds
            if (row + 3 < intArray.GetLength(0) && col - 3 >= 0)
            {
                for(int i = row; i <= row + 3; i++)
                {
                    product *= intArray[i, col - (i - row)];
                }
            }

            return product;
        }
    }
}
