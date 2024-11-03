using System;
class Program
{
    static void Main()
    {
        int counter = 0;
        do
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        } while (counter < 10);
    }
}
