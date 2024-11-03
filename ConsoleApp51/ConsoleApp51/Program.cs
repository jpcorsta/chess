using System.ComponentModel;
using System.Globalization;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var UserText = AskUserforDateOfBirth();

            AnnounceDateOfBirthInformation(UserText);
        }
        /// <summary>
        /// Introduce our Savvy robot
        /// </summary>
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hello, I am Savvy and I am really good in " +
                "guessing what day of the week you were born");
        }
        /// <summary>
        /// Ask the user for their date of birth until it is entered in a valid format or the application is terminated
        /// </summary>
        /// <remarks>
        /// this call will not return until a valid date is entered or the application is terminated
        /// </remarks>
        /// <returns>the date of birth the user entered</returns>
        public static DateTimeOffset AskUserforDateOfBirth()
        {
            var dateOfbirth = DateTimeOffset.MaxValue;

            while(dateOfbirth > DateTimeOffset.UtcNow)
            {
                Console.WriteLine($"Enter birthdate " +
                    $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                var birthDate = Console.ReadLine();

                if(DateTimeOffset.TryParse(birthDate, out var parsedDate))
                    dateOfbirth = parsedDate;

                else
                    Console.WriteLine("Wrong birthdate");
            }
            return dateOfbirth;
        }
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            var now = DateTimeOffset.UtcNow;

            Console.WriteLine($"You were born on {date:dd MMMM yyy}");

            Console.WriteLine($"That was a {date.DayOfWeek}");

            var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            Console.Write($"It is ");
            Console.BackgroundColor = ConsoleColor.Green;  
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{(nextBirthday - now).TotalDays:0}");
            Console.BackgroundColor = ConsoleColor.Black;   
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" days until your next birthday");

            var userAge =  now.Year - date.Year - (hasPassedBirthday? 0 : 1);

            Console.WriteLine($"You are {userAge} years old");




            Console.ReadLine();
        }
    }
}
