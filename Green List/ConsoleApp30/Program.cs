namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Program", "Routed Event", "Thread", "Application"};

            names.Add("Console");
            names.Add("Debug");
            names.Add("HttpClient");
            names.Add("MainWIndow");
            names.Add("Window");
            names.Add("");
            names.Add("");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}