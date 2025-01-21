IntroduceSavvy();

var inputData = AskForDateofBirth();

AnnounceDateOfBirthInformation(inputData);


static void IntroduceSavvy() 
{ 
	Console.WriteLine("Hello, I am Savvy and i am " +
		"really good in pulling the day off week out of " +
		"my calender registry");
}

static DateTimeOffset AskForDateofBirth() 
{ 
	var dateOfBirth = DateTimeOffset.MaxValue;

	while(dateOfBirth > DateTimeOffset.UtcNow)
	{
        Console.WriteLine("Enter birthdate");

		var enteredDate = Console.ReadLine();

		if(DateTimeOffset.TryParse(enteredDate, out var parsedDate))
			dateOfBirth = parsedDate;
		else
            Console.WriteLine("Enter parseble formatted date");
	}
	return dateOfBirth;
}
static void AnnounceDateOfBirthInformation(DateTimeOffset date)
{
	var now = DateTimeOffset.UtcNow;

    Console.WriteLine($"You were born on {date:d}");

    Console.Write("That was a ");
	Console.ForegroundColor = ConsoleColor.Green;	
	date.AddHours(1);
	Console.ResetColor();

	var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

	var nextbirthDay = new DateTimeOffset(now.Year + (hasPassedBirthday? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

    Console.WriteLine($"It is {(nextbirthDay-now).TotalDays:0} days until your next birthday");

	var userAge = now.Year - date.Year - (hasPassedBirthday? 0 : 1);

	Console.WriteLine($"You are {userAge} years old");
}