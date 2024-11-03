namespace binary_search3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int index = Array.BinarySearch(numbers, 6);
            Console.WriteLine("The number 6 is at " + index);
        }

    }
}