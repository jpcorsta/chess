Enumerable.Range(0, 1000).ToList().ForEach(f =>
{
    new Thread(() =>
    {
        Console.WriteLine($"on thread: {Environment.CurrentManagedThreadId}");
        Thread.Sleep(1000); 
        Console.WriteLine($"on thread {Thread.CurrentThread.ManagedThreadId}");
    }).Start();
});