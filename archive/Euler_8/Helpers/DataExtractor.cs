using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_8.Helpers
{
    internal class DataExtractor
    {
        public static List<int> TextFileToArrayOfInts(string filePath)
        {
            // Getting the input string as characters
            string line = File.ReadAllText(filePath);
            char[] chars = line.ToCharArray();

            List<int> ints = new List<int>();
            foreach(char c in chars)
            {
                int i = c - '0';
                ints.Add(i);
            }
            return ints;
        }
    }
}
