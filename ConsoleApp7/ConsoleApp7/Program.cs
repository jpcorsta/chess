using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write( "Enter your name:" );
            string name = Console.ReadLine();
            Console.Write("Enter your Age:");
            string age = Console.ReadLine();
            Console.WriteLine( "Hello " + name + " You are " + age);

            Console.ReadLine();
        }
    }
}
