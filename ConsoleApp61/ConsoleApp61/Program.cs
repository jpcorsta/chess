using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var userData = AskUserForDateOfBirth();

            AnnounceDateOfBirthInformation(userData);
        }
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hello, I am Savvy and " +
                "I am really in guessing what day of the week " +
                "you were born");
        }

        public static DateTimeOffset AskUserForDateOfBirth()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            while (dateOfBirth > DateTimeOffset.UtcNow)
            {
                Console.WriteLine($"Enter birthdate " +
                    $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                var userText = Console.ReadLine();

                if(DateTimeOffset.TryParse(userText, out var parsedDate))
                    dateOfBirth = parsedDate;

                else
                    Console.WriteLine("You did not enter a valid date");
            }
            return dateOfBirth;           
        }
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            var now = DateTimeOffset.UtcNow;

            Console.Write($"You were born on ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write($"{date:dd MMM yyy}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.WriteLine($"That was a {date.DayOfWeek}");

            var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            Console.WriteLine($"It is {(nextBirthday-now).TotalDays:0} days until your next birthday");

            var userAge = now.Year - date.Year - (hasPassedBirthday ? 0 : 1);

            Console.WriteLine($"You are {userAge} years old");

            var timeAlive = now - date;

            Console.WriteLine($"You are {timeAlive.Seconds:0} seconds old");

            Console.ReadKey();
        }
    }
}
