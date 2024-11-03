using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;

IntroduceSavvy();
var userInput = AskUserForDateOfBirth();
AnnounceDateOfBirthInformation(userInput);

///
static void IntroduceSavvy()
{
    Console.WriteLine("Hello, I " +
        "am Savvy, and i am really");
}
static DateTimeOffset AskUserForDateOfBirth()
{
    var dateOfBirth = DateTimeOffset.MaxValue;

    while(dateOfBirth > DateTimeOffset.UtcNow)
    {
        Console.WriteLine($"Enter birthdate " +
            $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

        var birthDate = Console.ReadLine();

        if(DateTimeOffset.TryParse(birthDate, out var parsedDate))
            dateOfBirth = parsedDate;

        else
            Console.WriteLine("You did not enter a valid date");
    }
    return dateOfBirth;
}


static void AnnounceDateOfBirthInformation(DateTimeOffset date)
{
    var now = DateTimeOffset.UtcNow;

    Console.WriteLine($"You were born on {date:dd MMM yyy}");

    Console.WriteLine($"That was a {date.DayOfWeek}");

    var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

    var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

    Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

    var userAge = now.Year - date.Year - (hasPassedBirthday ? 0 : 1);

    Console.WriteLine($"You are {userAge} years old");
}