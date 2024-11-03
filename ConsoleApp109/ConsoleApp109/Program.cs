IntroduceSavvy();
var userInput = AskUserForDateOfBirth();
AnnounceDateOfbirth(userInput);

static void IntroduceSavvy()
{
    Console.WriteLine("Hello I am Savvy " +
        "And I am really good in guessing what " +
        "day of the week you were born on");
}
static DateTimeOffset AskUserForDateOfBirth()
{
    var dateOfBirth = DateTimeOffset.MaxValue;

    while(dateOfBirth > DateTimeOffset.UtcNow)
    {
        Console.WriteLine("Enter birthdate");

        var givenDate = Console.ReadLine();

        if(DateTimeOffset.TryParse(givenDate, out var parsedDate))
            dateOfBirth = parsedDate;
        else
            Console.WriteLine("You did not enter a valid date");
    }
    return dateOfBirth;
}
static void AnnounceDateOfbirth(DateTimeOffset date)
{
    var now = DateTimeOffset.UtcNow;

    Console.WriteLine($"You were born on {date:dd MMM yyy}");

    Console.WriteLine($"That was a {date.DayOfWeek}");

    var hasPassedBirthday = date.DayOfYear > now.DayOfYear;

    var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday? 0 : 1), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

    Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

    var userAge = now.Year - date.Year - (hasPassedBirthday? 1 : 0);

    Console.WriteLine($);
}