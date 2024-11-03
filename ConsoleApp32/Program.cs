namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Hello, World!");

            new Thread(() =>
            {
                Thread.Sleep(10000);
            }).Start();    
                              
        }
    }
}