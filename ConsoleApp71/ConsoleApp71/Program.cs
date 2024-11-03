using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var userInput = AskUserForDateOfBirth();

            AnnounceDateOfBirthInformation(userInput);
        }
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hello I am Savvy, and I am " +
                "really good in guessing on what day of the " +
                "week you were born");
        }
        public static DateTimeOffset AskUserForDateOfBirth() 
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            Console.WriteLine($"Enter birthdate " +
                $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

            var givenDate = Console.ReadLine();

            while(dateOfBirth >  DateTimeOffset.UtcNow) 
            {
            if(DateTimeOffset.TryParse(givenDate, out var parsedDate)) 
                  dateOfBirth = parsedDate;

            else
                Console.WriteLine("You did not enter a valid date");
            }
            return dateOfBirth;
        }
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            var now = DateTimeOffset.UtcNow;

            Console.WriteLine($"You were born on {date:dd MMM yyy}");

            Console.Write($"That was a ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{date.DayOfWeek}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            var hasPassedBirthday = date.DayOfYear > now.DayOfYear;

            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 0 : 1), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

            var userAge = now.Year - date.Year - (hasPassedBirthday ? 1 :0);

            Console.WriteLine($"You are {userAge} years old");

            var timeAlive = now - date;

            Console.WriteLine($"You are {timeAlive.TotalSeconds:n0} seconds old");

            Console.ReadKey();

        }
    }
}
