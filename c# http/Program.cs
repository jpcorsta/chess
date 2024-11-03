using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace c__http
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programObject = new Program();
            programObject.SecretFunction();
        }
        void SecretFunction()
        {
            Console.WriteLine("You found me!");
            Console.ReadLine();
        }
    }

    class Car
    {
        public static string CarName(string carType)
        {
            return $"This is a {carType}";
        }
    }    
}