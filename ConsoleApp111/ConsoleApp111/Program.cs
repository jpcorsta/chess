using System.Globalization;

IntroduceSavvy();

var userInput = AskUserForDateOfBirth();

AnnounceDateOfBirth(userInput);

static void IntroduceSavvy()
{
    Console.WriteLine("Hello, I am Savvy and I am really +" +
        "good in guessing what day of the week you " +
        "were born on");
}

static DateTimeOffset AskUserForDateOfBirth()
{
    var dateOfBirth = DateTimeOffset.MaxValue;

    while(dateOfBirth > DateTimeOffset.UtcNow)
    {
        Console.WriteLine($"Enter birthdate " +
            $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

        var givenDate = Console.ReadLine();

        if (DateTimeOffset.TryParse(givenDate, out var parsedDate))
            dateOfBirth = parsedDate;

        else       
            Console.WriteLine("You did not enter a valid date");
        
    }
    return dateOfBirth;
}

static void AnnounceDateOfBirth(DateTimeOffset date)
{
    var now = DateTimeOffset.UtcNow;

    Console.WriteLine($"You were born on {date:dd MMM yyyy}");

    Console.WriteLine($"that was a {date.DayOfWeek}");

    var hasPassedBirthday = date.DayOfYear > now.DayOfYear;

    var nextBirthDay = new DateTimeOffset(now.Year + (hasPassedBirthday ? 0 : 1), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

    Console.WriteLine($"It is {(nextBirthDay - now).TotalDays:0} days until your next birthday");

    var userAge = now.Year - date.Year - (hasPassedBirthday ? 1 : 0);

    Console.Write("You are ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(userAge);
    Console.ResetColor();
    Console.Write(" years old");
    Console.WriteLine( );

    var timeAlive = now - date;

    Console.WriteLine($"You are {timeAlive.TotalSeconds:n0} seconds old");


}

