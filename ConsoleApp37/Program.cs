namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetTitle("");
            Console.WriteLine(car.GetTitle());
            Console.ReadLine();
        }
    }

    class Car
    {
        private string title;
        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }
    }
}