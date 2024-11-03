namespace ConsoleApp27
{
    internal class TaskInConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bewerking");

            return;

            //
            // What is Asynchronous
            //

        }
        public static async Task DoWork()
        {
            await Task.Delay(1000);
        }

    }   
}