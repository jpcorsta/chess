using System.Globalization;
using System.Windows.Markup;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // introduce Savvy the robot
            IntroduceSavvy();
            
            // Ask the user for their date of birth
            var userDate = AskUserForDateOfBirth();

            AnnounceDateOfBirthInformation(userDate);
        }
        /// <summary>
        /// Introduce Savvy the robot to our user
        /// </summary>
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hello, I am Savvy and I am really good " +
                "in guessing what day of the week you were born on");
        }
        /// <summary>
        /// Ask the usert for their date of birth until it is given in a valid format
        /// </summary>
        /// <remarks>this call will not return until a valid date is entered or the application is terminated</remarks>
        /// <returns>the date of birth the user entered</returns>
        public static DateTimeOffset AskUserForDateOfBirth()
        {
            // Create checked date with initial out of range value
            var dateOfBirth = DateTimeOffset.MaxValue;

            // until the checked date is greater then today
            while(dateOfBirth > DateTimeOffset.UtcNow)
            {
                // Ask the user for their date of birth
                Console.WriteLine($"Enter birthdate " +
                    $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                // Read their response
                var userText = Console.ReadLine();

                // if the user entered a valid date
                if(DateTimeOffset.TryParse(userText, out var parsedDate))
                    
                    // set the checked date to the users given date
                    dateOfBirth = parsedDate;

                // otherwise
                else

                    // inform user they entered a invalid date
                    Console.WriteLine("You did not enter a valid birthdate");
            }
            // return the result
            return dateOfBirth;
        }
        /// <summary>
        /// display information to the user about the given date of birth
        /// </summary>
        /// <param name="date"></param>
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            // Store current time
            var now = DateTimeOffset.UtcNow;

            // display birthdate to the user
            Console.WriteLine($"You were born on {date:dd MMM yyy}");

            // display day of week they were born on
            Console.WriteLine($"That was a {date.DayOfWeek}");

            // indicate if we have already passed the users birthday for the current year
            var hasPassedBirthday = now.DayOfYear > date.DayOfYear;
            
            // get a date representing the users next birthday
            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            // display how many days until the users next birthday
            Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

            // get user age
            var userAge = now.Year - date.Year - (hasPassedBirthday ? 0 : 1);

            // display user age
            Console.Write("You are ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{userAge}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" years old");
            Console.WriteLine();

            // get time alive
            var timeAlive = now - date;

            // display days old
            Console.WriteLine($"You are {timeAlive.TotalDays:n0} days old");

            // display hours old
            Console.WriteLine($"You are {timeAlive.TotalSeconds:n0} seconds old");

            // display milliseconds old
            Console.WriteLine($"You are {timeAlive.TotalMilliseconds:n0} milliseconds old");



            Console.ReadLine();
        }
    }
}
