using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ConsoleApp86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var userText = AskUserForDateOfBirth();

            AnnounceDateOfBirthInformation(userText);
        }
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hello, I am Savvy and " +
                "I am really good in guessing " +
                "what day of the week you were born");
        }
        public static DateTimeOffset AskUserForDateOfBirth()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            while(dateOfBirth > DateTimeOffset.UtcNow) 
            {
                Console.WriteLine($"Enter birthdate " +
                    $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                var usersGivenDate = Console.ReadLine();

                if(DateTimeOffset.TryParse(usersGivenDate, out var parsedDate)) 
                    dateOfBirth = parsedDate;

                else
                    Console.WriteLine("You did not enter a valid date");
            }
            return dateOfBirth;
        }
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            var now = DateTimeOffset.UtcNow;

            Console.Write("You were born on ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{date:dd MMM yyyy}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"That was a {date.DayOfWeek}");

            var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0),date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

            var timeAlive = now - date;

            Console.WriteLine($"You are {timeAlive.TotalMinutes:n0} minutes old");

        }
    }
}
