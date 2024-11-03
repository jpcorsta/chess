namespace NewLock;
public class Example
{
    public int Sum { get; private set; }

    private static readonly object PadLock = new();

    public void Add(int number) 
    { 
        lock (PadLock) 
        {
            Sum += number; 
        }
    }
}
