using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_11.Helpers
{
    public class DataAccessor
    {
        public static int[,] TextFileToArrayOfInts(string filePath)
        {
            // Accessing the data from the file
            string[] lines = File.ReadAllLines(filePath);
            List<List<int>> listOfIntsLists = new List<List<int>>();

            // Converting each substring into an int and adding it to a list
            foreach (string line in lines)
            {
                List<int> ints = new List<int>();

                string[] intStrings = line.Split(' ');
                foreach (string intString in intStrings)
                {
                    ints.Add(int.Parse(intString));
                }
                listOfIntsLists.Add(ints);
            }

            // Converting to an array
            int rows = listOfIntsLists.Count;
            int cols = listOfIntsLists[0].Count;
            int[,] intArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    intArray[i, j] = listOfIntsLists[i][j];
                }
            }

            return intArray;
        }
    }
}
