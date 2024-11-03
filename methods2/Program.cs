namespace methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 67);
            SayHi("ike", 156);
            SayHi("ke", 6);
            SayHi("e", 5);

            Console.ReadLine();
        }

        static void SayHi(string name, int age )
        {
            Console.WriteLine("Hello " + name + " you are " + age);
            Console.WriteLine("_______________________");
        }
    }
}

   