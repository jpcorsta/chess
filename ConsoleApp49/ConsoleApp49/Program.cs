using System.Globalization;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introduce our Savvy robot to our user
            IntroduceSavvy();

            // Ask the user for their date of birth
            var userDate = AskUserForDateOfBirth();

            // Announce information about date of birth
            AnnounceDateOfBirthInformation(userDate);
        }
        public static void IntroduceSavvy()
        {
            // Introduce our Savvy robot
            Console.WriteLine("Hello, I am Savvy and I am really good " +
                "in guessing what day of the week you were born");
        }
        /// <summary>
        /// Ask the user for their date of birth until it is entered in a correct format.
        /// </summary>
        /// <remarks>
        /// This call will not return until a valid date is entered or the application is terminated
        /// </remarks>
        /// <returns>the date of birth the user entered</returns>
        public static DateTimeOffset AskUserForDateOfBirth()
        {
            // create checked date with initial out of range value
            var dateOfBirth = DateTimeOffset.MaxValue;

            // Until the checked date is greater then today
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
                    // inform user they entered invalid date
                    Console.WriteLine("You did not enter a valid date");
            }
            // return the result
            return dateOfBirth;
        }
        /// <summary>
        /// Display information to the user about the given date of birth
        /// </summary>
        /// <param name="date">the birthdate to display information about</param>
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            // Store current time
            var now = DateTimeOffset.UtcNow;

            // display birthdate
            Console.WriteLine($"You were born on {date:dd MMM yy}");

            // display day of the week they were born on
            Console.Write("That was a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{date.DayOfWeek}" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            // indicate if we have already passed the users birthday for the current year
            var hasPassedBirthday =  now.DayOfYear > date.DayOfYear;

            // Get a date representing the users next birthday
            var nextBirthday = new DateTimeOffset(now.Year + (hasPassedBirthday ? 1 : 0),date.Month, date.Day, 0,0,0, TimeSpan.Zero);

            // display how many days till the users next birthday
            Console.WriteLine($"It is {(nextBirthday - now).TotalDays:0} days until your next birthday");

            // get user age
            var userAge = now.Year - date.Year - (hasPassedBirthday ? 0 : 1);

            // display user age
            Console.WriteLine($"You are {userAge} years old");

            // get time alive
            var timeAlive = now - date;

            // display how many seconds old
            Console.WriteLine($"You are {timeAlive.TotalSeconds:n0} seconds old");

            Console.ReadLine();
        }
    }
}
