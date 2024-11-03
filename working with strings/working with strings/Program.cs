namespace working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy" + " is cool";//concatenate
            Console.WriteLine(phrase.Substring(8, 3));//grabs 12 characters starting at index 8
        }
    }
}