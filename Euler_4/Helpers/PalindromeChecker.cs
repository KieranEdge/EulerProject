using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4.Helpers
{
    public static class PalindromeChecker
    {
        public static bool IsThisNumberAPalindrome(int number)
        {
            // Converting the number to a string
            string numberAsAString = number.ToString();
            
            // Reversing the string
            char[] chars = numberAsAString.ToCharArray();
            Array.Reverse(chars);
            string reversedNumber = new string(chars);

            // Returning the logical check
            return numberAsAString == reversedNumber;
        }
    }
}
