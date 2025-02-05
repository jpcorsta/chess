using System.Data;

IntroduceSavvy();

var dateOfBirth = AskUserForDateOfBirth();

announceDateOfBirthInformation(dateOfBirth);

static void IntroduceSavvy() 
{ 
	Console.WriteLine("Hello, " +
		"I am Savvy " +
		"and i am really goog");
}
static DateTimeOffset AskUserForDateOfBirth() 
{ 
	var dateOfBirth = DateTimeOffset.MaxValue;

	while(dateOfBirth > DateTimeOffset.UtcNow) 
	{
		Console.WriteLine("Enter birthdate");

		var userInput = Console.ReadLine();

		if(DateTimeOffset.TryParse(userInput, out var parsedDate))
			dateOfBirth = parsedDate;

		else
			Console.WriteLine("You did not enter a valid date ");
	}
	return dateOfBirth;
}
static void announceDateOfBirthInformation(DateTimeOffset date) 
{ 
	var now = DateTimeOffset.UtcNow;

	Console.WriteLine($"You were born on {date:dd MMM yyy}");

	Console.WriteLine($"That was a {date.DayOfWeek}");

	var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

	var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0),date.Month, date.Day, 0,0,0, TimeSpan.Zero);

	Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");
}