namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var birthdate = 1981;

            var age = DateTimeOffset.Now.Year - birthdate;


            var now = DateTime.Now;


            Console.WriteLine($"{age}");

            Console.ReadLine();
        }
    }
}
