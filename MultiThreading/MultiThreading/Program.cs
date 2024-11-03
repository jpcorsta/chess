namespace MultiThreading
{
    internal class Program
    {
        static async void Main(string[] args)//main = function
        {
            Console.ReadLine();
            Console.WriteLine("Hello World!");
            
            await Task.Run(async () =>
            {
                await Task.Delay(10000);
                Console.WriteLine("Starting download...");
                var webClient = new HttpClient();
                var html = webClient.GetStringAsync("Http://angelsix");
                Console.WriteLine("Done downloading");
            });

           Console.WriteLine("All done");
            
            Console.ReadLine();
        }
    }
}