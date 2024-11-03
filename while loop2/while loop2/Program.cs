using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            //while the lights are on
            while(counter < 10000)
            {
                counter = counter + 1;
                Console.WriteLine(counter +" turn OFF THE LIGHTS!");                              
            }

            // end of program
            Console.WriteLine("Please Enter to terminate program");

            Console.ReadLine();
        }
    }
}
