using System.Globalization;

namespace ConsoleApp55
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
            Console.WriteLine("Hello, I am Savvy and I am really good " +
                "in guessing on what day of the week you were born");
        }
        public static DateTimeOffset AskUserForDateOfBirth()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;

            while(dateOfBirth > DateTimeOffset.UtcNow)
            {
                Console.WriteLine($"Enter birthdate " +
                    $"{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");

                string userText = Console.ReadLine();

                if(DateTimeOffset.TryParse(userText, out var parsedDate))
                    dateOfBirth = parsedDate;

                else
                    Console.WriteLine("Wrong date");
            }
            return dateOfBirth;
        }
        public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
        {
            var now = DateTimeOffset.UtcNow;

            Console.WriteLine($"You were born on {date:dd MM yy}");

            Console.ReadLine();
        }
    }
}
