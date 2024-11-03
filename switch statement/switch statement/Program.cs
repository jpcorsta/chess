using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 2;
            
            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club");
            }else if (age == 25)
            {
                Console.WriteLine("Good to go");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Frank";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("username is Denis");
                    break;
                case "Root":
                    Console.WriteLine("username is Root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }
        }
    }
}
