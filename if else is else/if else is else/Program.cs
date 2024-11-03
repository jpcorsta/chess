using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace if_else_is_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tijd = 1;

            if (tijd < 4)
            {
                Console.WriteLine("goedenacht");
            }
            else if (tijd < 10)
            {
                Console.WriteLine("Goedemorgen");
            }
            else if (tijd < 20)
            {
                Console.WriteLine("goededag");
            }
            else
            {
                Console.WriteLine("goedeavond");
            }
        }
    }
}
