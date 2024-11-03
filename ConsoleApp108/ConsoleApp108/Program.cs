namespace ConsoleApp108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var userDate = AskUserForDateOfBirth();

            AnnounceDateOfBirthInformation(userDate);
        }

        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hello, I am Savvy and I am really good in " +
                "guessing what day of the week you were born on");
        }
        public static DateTimeOffset AskUserForDateOfBirth()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            while(dateOfBirth > DateTimeOffset.UtcNow)
            {
                Console.WriteLine("Enter birthdate");

                var userInput = Console.ReadLine();

                if(DateTimeOffset.TryParse(userInput, out var parsedDate))
                    dateOfBirth = parsedDate;

                else
                    Console.WriteLine("You did not enter a valid date");

            }
            return dateOfBirth;

        }
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            var now = DateTimeOffset.UtcNow;

            Console.WriteLine($"You were born on {date:dd MMM yyyy}");

            Console.WriteLine($"That was a {date.DayOfWeek}");

            var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            Console.WriteLine($"It is {(nextBirthday-now).TotalDays:0} days until your next birthday");

            var userAge = now.Year - date.Year -(hasPassedBirthday ? 0 : 1);

            Console.WriteLine(userAge);
        }

    }
}
