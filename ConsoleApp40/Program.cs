namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before blocking thread");

            var blockingThread = new Thread(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Inside blocking thread");
            });

            blockingThread.Start();

            //block and wait
            blockingThread.Join();

            Console.WriteLine("After blocking thread");
        }
    }
}