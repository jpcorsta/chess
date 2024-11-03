namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Hello, World!");

                                    
            new Thread(() =>
            {
                Thread.Sleep(2000);
               
            }).Start();
                     
        }
    }
}