using System.Globalization;

namespace ConsoleApp95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();
            var userDate = AnnounceDateOfBirthInformation();

            AnnounceDateOfBirthInformation(userDate);
        }
        /// <summary>
        /// Introduce our Savvy robot
        /// </summary>
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hello, I am savvy and " +
                "I am really good in guessing what " +
                "day of the week you were born");
        }
        /// <summary>
        /// Ask the user for their date of birth until it is entered in a valid format
        /// </summary>
        /// <remarks>
        /// this call will not return until a valid date is entered 
        /// or the application is terminated
        /// </remarks>
        /// <returns>the date of birth the user entered</returns>
        public static DateTimeOffset AnnounceDateOfBirthInformation()
        {
            // create checked date with initial out of range value
            var dateOfBirth = DateTimeOffset.MaxValue;

            // until the checked date is greater then today
            while(dateOfBirth > DateTimeOffset.UtcNow) 
            {
                // ask the user for their date of birth
                Console.WriteLine($"Enter birthdate " +
                    $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                // if the user entered a valid date
                var birthDate = Console.ReadLine();

                // set the checked date to the users given date
                if(DateTimeOffset.TryParse(birthDate, out var parsedDateOfBirth) )
                    dateOfBirth = parsedDateOfBirth;

                // otherwise inform user they entered invalid date
                else
                    Console.WriteLine("You did not enter a valid date");
            }
            // return the result
            return dateOfBirth;
        }
        /// <summary>
        /// Display information to the user about the given birthDate
        /// </summary>
        /// <param name="date"></param>
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            // store current time
            var now = DateTimeOffset.UtcNow;
                        
            // display birthdate
            Console.WriteLine($"You were born on {date:dd MMM yyy}");

            // display day of the week the user was born on
            Console.WriteLine($"That was a {date.DayOfWeek}");

            // indicate if we have already passed the users birthday for the current year
            var hasPassedBirthday = now.DayOfYear > date.DayOfYear;

            // get a date representing the users next birthday
            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            // display how many days until the users next birthday
            Console.Write($"It is {(nextBirthday - now).TotalDays:0} days until your ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("next birthday");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
