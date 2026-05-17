namespace Euler_17.Helpers;

public class NumberDictionary
{
    public Dictionary<int, int> UnitsAndTeensDictionary = new Dictionary<int, int>
    {
        {0, 0},
        {1, 3},
        {2, 3},
        {3, 5},
        {4, 4},
        {5, 4},
        {6, 3},
        {7, 5},
        {8, 5},
        {9, 4},
        {10, 3},
        {11, 6},
        {12, 6},
        {13, 8},
        {14, 8},
        {15, 7},
        {16, 7},
        {17, 9},
        {18, 8},
        {19, 8},
    };
    public Dictionary<int, int> TensDictionary = new Dictionary<int, int>
    {
        {0, 0},
        {20, 6},
        {30, 6},
        {40, 5},
        {50, 5},
        {60, 5},
        {70, 7},
        {80, 6},
        {90, 6},
    };

    public int ReturnNumberValue(int number)
    {
        if (number < 20)
        {
            return UnitsAndTeensDictionary[number];
        }
        else if (number >= 20 && number < 100)
        {
            int unitValue = UnitsAndTeensDictionary[UnitsReturn(number)];
            int tenValue = TensDictionary[TensColumnReturn(number)];
            return unitValue + tenValue;
        }
        else if (number >= 100 && number < 1000)
        {
            int unitValue = UnitsAndTeensDictionary[UnitsReturn(number)];
            int tenValue = TensColumnReturn(number);
            if (tenValue < 20)
            {
                tenValue = UnitsAndTeensDictionary[tenValue];
            }
            else
            {
                tenValue = TensDictionary[tenValue];
            }
            
            int hundredsValue = UnitsAndTeensDictionary[HundredsColumnReturn(number)] + 10;
            return unitValue + tenValue + hundredsValue;
        }
        else
        {
            // 1000 use case
            return 11;
        }
    }

    public static int UnitsReturn(int number)
    {
        if (number < 100)
        {
            string intAsString = number.ToString();
            int unitValue = intAsString[1] - '0';
            return unitValue;
        }
        else
        {
            string intAsString = number.ToString();
            int unitValue = intAsString[2] - '0';
            return unitValue;
        }
    }
    public static int TensColumnReturn(int number)
    {
        if (number < 100)
        {
            string intAsString = number.ToString();
            int tenValue = intAsString[0] - '0';

            if (tenValue == 1)
            {
                return number;
            }
            else return tenValue * 10;
            
        }
        else
        {
            string intAsString = number.ToString();
            int tenValue = intAsString[1] - '0';

            if (tenValue == 1)
            {
                char tenDigit = intAsString[1];
                char unitDigit = intAsString[2];
                char[] charactersArray= {tenDigit, unitDigit};
                string teens = new string(charactersArray);
                return int.Parse(teens);
            }
            else
            {
                return tenValue * 10;
            }
        }
    }

    public static int HundredsColumnReturn(int number)
    {
        string intAsString = number.ToString();
        int hundredsValue = intAsString[0] - '0';
        return hundredsValue;
    }
}