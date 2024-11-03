using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
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
            Console.WriteLine("Hello I am Savvy and" +
                " i am really good in guessing what day of the " +
                "week you were born on");
        }
        public static DateTimeOffset AskUserForDateOfBirth()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            while(dateOfBirth > DateTimeOffset.UtcNow) 
            {
                Console.WriteLine($"Enter birthdate " +
                    $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                var userText = Console.ReadLine();

                if(DateTimeOffset.TryParse(userText, out var parsedDate) )
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

            Console.Write("That was a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"{date.DayOfWeek}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();

            bool hasPassedBirthday = now.DayOfYear > date.DayOfYear;

            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

            var userAge = now.Year - date.Year - (hasPassedBirthday ? 0 : 1);

            Console.WriteLine($"You are {userAge} years old");

            var timeAlive = now - date;

            Console.WriteLine($"You are {timeAlive.TotalSeconds:n0} seconds old");

            Console.ReadKey();
        }

    }
}
