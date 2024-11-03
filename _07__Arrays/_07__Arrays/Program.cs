using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07__Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            //create an array with 5 off your best friends
            //create a for eachloop wich greets all off them

            string[] myFriends = { "Michael", "Stephan", "Coen", "Henk", "Paul" };

            foreach(string name in myFriends)
            {
                Console.WriteLine("Hi {0}", name);
            }
           
        }
    }
}
