using Microsoft.VisualBasic;
using System.Globalization;

IntroduceSavvy();
var userTest = AskUserForDateOfBirth();
AnnounceDateOfBirthInformation(userTest);
static void IntroduceSavvy()
{
    Console.WriteLine("Hello, i am savvy " +
        "and i am really good in guessing " +
        "what day of the week you were born on");
}

static DateTimeOffset AskUserForDateOfBirth()
{
    var dateBirth = DateTimeOffset.MaxValue;

    while(dateBirth > DateTimeOffset.UtcNow)
    {
        Console.WriteLine($"Enter birthdate " +
            $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

        var dateOfBirth = Console.ReadLine();

        if (DateTimeOffset.TryParse(dateOfBirth, out var parsedDate))
            dateBirth = parsedDate;

        else
            Console.WriteLine("You did not enter a valid date");
    }
    return dateBirth;
}
static void AnnounceDateOfBirthInformation(DateTimeOffset date)
{
    var now = DateTimeOffset.UtcNow;

    Console.Write("You were born on ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{date:dd MMM yy}");
    Console.ResetColor();
    Console.WriteLine();    

    Console.WriteLine($"That was a {date.DayOfWeek}");

    var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

    var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

    Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

    var userAge = now.Year - date.Year - (hasPassedBirthday? 0 : 1);

    Console.WriteLine($"You are {userAge} years old");

    var timeAlive = now - date;

    Console.WriteLine($"You are {timeAlive.TotalMinutes:n0} minutes old");

}