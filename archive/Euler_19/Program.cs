int year = 1901;

Dictionary<string, int> monthsAndDays = new Dictionary<string, int>
{
    { "January", 31 },
    { "February", 28 },
    { "February_Leap", 29 },
    { "March", 31 },
    { "April", 30 },
    { "May", 31 },
    { "June", 30 },
    { "July", 31 },
    { "August", 31 },
    { "September", 30 },
    { "October", 31 },
    { "November", 30 },
    { "December", 31 }
};

List<string> standardYear = new List<string>{
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
};
List<string> leapYear = new List<string>{
    "January",
    "February_Leap",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
};

int numOfSundaysOnTheFirst = 0;

List<string> daysOfTheWeek = new List<string>
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
int currentDay = 1;

while (year < 2001)
{
    List<string> currentYearReferenceList = new List<string>();

    // Specifying which year configureation to use
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        currentYearReferenceList = leapYear;
    }
    else
    {
        currentYearReferenceList = standardYear;
    }

    // Iterating over each month in the year
    foreach (string month in currentYearReferenceList)
    {
        // Iterating over each month in the year to see if the first is a sunday
        for (int date = 1; date <= monthsAndDays[month]; date++)
        {
            if (date == 1 && daysOfTheWeek[currentDay] == "Sunday")
            {
                Console.WriteLine($"{year}/{month}/{date} is Sunday ");
                numOfSundaysOnTheFirst++;
            }
            currentDay++;
            if (currentDay == 7)
            {
                currentDay = 0;
            }
        }
    }
    year++;
}
Console.WriteLine(numOfSundaysOnTheFirst);