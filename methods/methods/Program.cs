using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33);
            SayHi("John", 34);
            SayHi("Tom", 42);
            Console.ReadLine();
        }

        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello " + name + "You are " + age);
        }
    }
}
